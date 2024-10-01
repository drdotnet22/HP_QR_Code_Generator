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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(76, 392);
            button1.Name = "button1";
            button1.Size = new Size(190, 47);
            button1.TabIndex = 6;
            button1.Text = "Run Generator";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // targetURL
            // 
            targetURL.Location = new Point(72, 137);
            targetURL.Name = "targetURL";
            targetURL.Size = new Size(415, 23);
            targetURL.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 119);
            label1.Name = "label1";
            label1.Size = new Size(267, 15);
            label1.TabIndex = 2;
            label1.Text = "Target URL !!! (Must begin with http:// or https://)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 174);
            label2.Name = "label2";
            label2.Size = new Size(211, 15);
            label2.TabIndex = 3;
            label2.Text = "Job Number (Must be a 5 digit integer)";
            // 
            // jobNumber
            // 
            jobNumber.Location = new Point(72, 192);
            jobNumber.MaxLength = 5;
            jobNumber.Name = "jobNumber";
            jobNumber.Size = new Size(92, 23);
            jobNumber.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 232);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 5;
            label3.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 299);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 7;
            label4.Text = "Output folder";
            // 
            // folderPath
            // 
            folderPath.Location = new Point(76, 322);
            folderPath.Name = "folderPath";
            folderPath.Size = new Size(411, 23);
            folderPath.TabIndex = 5;
            // 
            // selectPathButton
            // 
            selectPathButton.Location = new Point(157, 295);
            selectPathButton.Name = "selectPathButton";
            selectPathButton.Size = new Size(101, 22);
            selectPathButton.TabIndex = 4;
            selectPathButton.Text = "Select Path";
            selectPathButton.UseVisualStyleBackColor = true;
            selectPathButton.Click += selectPathButton_Click;
            // 
            // quantity
            // 
            quantity.Location = new Point(76, 249);
            quantity.MaxLength = 5;
            quantity.Name = "quantity";
            quantity.Size = new Size(88, 23);
            quantity.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 600);
            Controls.Add(quantity);
            Controls.Add(selectPathButton);
            Controls.Add(folderPath);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(jobNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(targetURL);
            Controls.Add(button1);
            Name = "Form1";
            Text = "HP QRCode Generator";
            ResumeLayout(false);
            PerformLayout();
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
    }
}
