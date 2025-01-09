namespace HP_QR_Code_Generator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            targetURL = new TextBox();
            label1 = new Label();
            label2 = new Label();
            jobNumber = new TextBox();
            label3 = new Label();
            label4 = new Label();
            folderPath = new TextBox();
            selectPathButton = new Button();
            quantity = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            selectCustomListOutputPath = new Button();
            customListOutputPath = new TextBox();
            label6 = new Label();
            selectCsvButton = new Button();
            csvPath = new TextBox();
            label5 = new Label();
            label7 = new Label();
            csvColumnNumber = new NumericUpDown();
            generateQrFromCustomList = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)csvColumnNumber).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(28, 273);
            button1.Name = "button1";
            button1.Size = new Size(200, 45);
            button1.TabIndex = 6;
            button1.Text = "Run Generator";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // targetURL
            // 
            targetURL.Location = new Point(28, 39);
            targetURL.Name = "targetURL";
            targetURL.Size = new Size(425, 23);
            targetURL.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 21);
            label1.Name = "label1";
            label1.Size = new Size(268, 15);
            label1.TabIndex = 2;
            label1.Text = "Target URL !!! (Must begin with http:// or https://)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 76);
            label2.Name = "label2";
            label2.Size = new Size(211, 15);
            label2.TabIndex = 3;
            label2.Text = "Job Number (Must be a 5 digit integer)";
            // 
            // jobNumber
            // 
            jobNumber.Location = new Point(28, 94);
            jobNumber.MaxLength = 5;
            jobNumber.Name = "jobNumber";
            jobNumber.Size = new Size(90, 23);
            jobNumber.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 134);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 5;
            label3.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 201);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 7;
            label4.Text = "Output folder";
            // 
            // folderPath
            // 
            folderPath.Location = new Point(28, 224);
            folderPath.Name = "folderPath";
            folderPath.Size = new Size(425, 23);
            folderPath.TabIndex = 5;
            // 
            // selectPathButton
            // 
            selectPathButton.Location = new Point(113, 197);
            selectPathButton.Name = "selectPathButton";
            selectPathButton.Size = new Size(101, 22);
            selectPathButton.TabIndex = 4;
            selectPathButton.Text = "Select Path";
            selectPathButton.UseVisualStyleBackColor = true;
            selectPathButton.Click += selectPathButton_Click;
            // 
            // quantity
            // 
            quantity.Location = new Point(28, 151);
            quantity.MaxLength = 5;
            quantity.Name = "quantity";
            quantity.Size = new Size(90, 23);
            quantity.TabIndex = 3;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(40, 25);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(932, 555);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(quantity);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(selectPathButton);
            tabPage1.Controls.Add(targetURL);
            tabPage1.Controls.Add(folderPath);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(jobNumber);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(924, 527);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Our API";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(generateQrFromCustomList);
            tabPage2.Controls.Add(csvColumnNumber);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(selectCustomListOutputPath);
            tabPage2.Controls.Add(customListOutputPath);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(selectCsvButton);
            tabPage2.Controls.Add(csvPath);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(924, 527);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Custom List";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // selectCustomListOutputPath
            // 
            selectCustomListOutputPath.Location = new Point(133, 109);
            selectCustomListOutputPath.Name = "selectCustomListOutputPath";
            selectCustomListOutputPath.Size = new Size(101, 22);
            selectCustomListOutputPath.TabIndex = 8;
            selectCustomListOutputPath.Text = "Select Path";
            selectCustomListOutputPath.UseVisualStyleBackColor = true;
            selectCustomListOutputPath.Click += selectCustomListOutputPath_Click;
            // 
            // customListOutputPath
            // 
            customListOutputPath.Location = new Point(46, 137);
            customListOutputPath.Name = "customListOutputPath";
            customListOutputPath.Size = new Size(425, 23);
            customListOutputPath.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 116);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 10;
            label6.Text = "Output folder";
            // 
            // selectCsvButton
            // 
            selectCsvButton.Location = new Point(142, 32);
            selectCsvButton.Name = "selectCsvButton";
            selectCsvButton.Size = new Size(101, 22);
            selectCsvButton.TabIndex = 6;
            selectCsvButton.Text = "Select CSV file";
            selectCsvButton.UseVisualStyleBackColor = true;
            selectCsvButton.Click += selectCsvButton_Click;
            // 
            // csvPath
            // 
            csvPath.Location = new Point(46, 63);
            csvPath.Name = "csvPath";
            csvPath.Size = new Size(425, 23);
            csvPath.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 36);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 0;
            label5.Text = "Select a CSV file";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 201);
            label7.Name = "label7";
            label7.Size = new Size(327, 15);
            label7.TabIndex = 11;
            label7.Text = "Enter column number (not letter) of the URL in CSV database";
            // 
            // csvColumnNumber
            // 
            csvColumnNumber.Location = new Point(46, 219);
            csvColumnNumber.Name = "csvColumnNumber";
            csvColumnNumber.Size = new Size(120, 23);
            csvColumnNumber.TabIndex = 12;
            // 
            // generateQrFromCustomList
            // 
            generateQrFromCustomList.Location = new Point(46, 290);
            generateQrFromCustomList.Name = "generateQrFromCustomList";
            generateQrFromCustomList.Size = new Size(120, 43);
            generateQrFromCustomList.TabIndex = 13;
            generateQrFromCustomList.Text = "Generate QR ";
            generateQrFromCustomList.UseVisualStyleBackColor = true;
            generateQrFromCustomList.Click += generateQrFromCustomList_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 600);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "HP QRCode Generator";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)csvColumnNumber).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TextBox targetURL;
        private Label label1;
        private Label label2;
        private TextBox jobNumber;
        private Label label3;
        private Label label4;
        private TextBox folderPath;
        private Button selectPathButton;
        private TextBox quantity;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button selectCsvButton;
        private TextBox csvPath;
        private Label label5;
        private Button selectCustomListOutputPath;
        private TextBox customListOutputPath;
        private Label label6;
        private NumericUpDown csvColumnNumber;
        private Label label7;
        private Button generateQrFromCustomList;
    }
}
