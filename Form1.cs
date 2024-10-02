using QRCoder;
using System.Diagnostics;
using System.Net;

namespace HP_QR_Code_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int qty = Convert.ToInt16(quantity.Text);
            string jobNum = jobNumber.Text;
            string encodedURL = WebUtility.UrlEncode(targetURL.Text);
            string folderPathStr = folderPath.Text;

            //Set up progress bar
            ProgressBar progressBar = new ProgressBar();
            progressBar.Location = new Point(76, 435);
            progressBar.Size = new Size(411, 23);
            progressBar.Name = "progressBar";
            Controls.Add(progressBar);
            progressBar.Minimum = 0;
            progressBar.Maximum = qty;

            //Loop and update progress
            for (int i = 1; i <= qty; i++)
            {
                string sequence = i.ToString().PadLeft(5, '0');
                progressBar.Value = i;
                Generator(jobNum, sequence, folderPathStr, encodedURL);
            }
            Controls.Remove(progressBar);

            Button goToFolder = new Button();
            goToFolder.Text = "Go to output folder";
            goToFolder.Location = new Point(76, 435);
            goToFolder.Size = new Size(411, 23);
            goToFolder.Click += goToFolder_Click;
            Controls.Add(goToFolder);

            Button restart = new Button();
            restart.Text = "Clear form";
            restart.Location = new Point(272, 371);
            restart.Size = new Size(200, 45);
            restart.Click += reset_Click;
            Controls.Add(restart);
        }

        static void Generator(string jobNumber, string sequence, string folderPathStr, string targetUrl)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            string url = new string("https://api.hprinting.com/api/QRCode/" + sequence + jobNumber + "/" + targetUrl);
            QRCodeData qRCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.L);
            PngByteQRCode qrCode = new PngByteQRCode(qRCodeData);
            byte[] qrCodeAsPngByteArr = qrCode.GetGraphic(20);

            using (var ms = new MemoryStream(qrCodeAsPngByteArr))
            {
                var qrCodeImage = new Bitmap(ms);
                qrCodeImage.Save(folderPathStr + "/" + sequence + jobNumber + ".png");
            }
        }

        private void selectPathButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                folderBrowser.Description = "Select a folder";
                folderBrowser.ShowNewFolderButton = true;

                // Show the dialog and check if the user clicked OK
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected folder path
                    string selectedPath = folderBrowser.SelectedPath;

                    folderPath.Text = selectedPath;
                }
            }
        }

        private void goToFolder_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", folderPath.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening path: {ex.Message}");
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(this);
        }
    }
}
