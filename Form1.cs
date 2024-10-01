using QRCoder;
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
            for (int i = 1; i <= qty; i++)
            {
                string sequence = i.ToString().PadLeft(5, '0');
                Generator(jobNum, sequence, folderPathStr, encodedURL);
            }
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

        private void targetURL_TextChanged(object sender, EventArgs e)
        {

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

                    folderPath.Text = selectedPath; // You can store it in a TextBox if desired
                }
            }
        }
    }
}
