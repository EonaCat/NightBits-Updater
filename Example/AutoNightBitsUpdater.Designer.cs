namespace WinformsExample.NightBitsUpdater
{
    partial class AutoNightBitsUpdater
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoNightBitsUpdater));
            this.updateButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.fileDescriptionInformationLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.updateVersionLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.updateInformationLabel = new System.Windows.Forms.Label();
            this.totalSizeLabel = new System.Windows.Forms.Label();
            this.receivedLabel = new System.Windows.Forms.Label();
            this.fileInformationLabel = new System.Windows.Forms.Label();
            this.applicationVersionLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productURLLabel = new System.Windows.Forms.LinkLabel();
            this.label13 = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.errorLabel = new System.Windows.Forms.Label();
            this.percentageLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(701, 260);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(131, 23);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Check for updates";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 136);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Short Info:";
            // 
            // fileDescriptionInformationLabel
            // 
            this.fileDescriptionInformationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileDescriptionInformationLabel.BackColor = System.Drawing.Color.Transparent;
            this.fileDescriptionInformationLabel.Location = new System.Drawing.Point(104, 136);
            this.fileDescriptionInformationLabel.Name = "fileDescriptionInformationLabel";
            this.fileDescriptionInformationLabel.Size = new System.Drawing.Size(728, 13);
            this.fileDescriptionInformationLabel.TabIndex = 19;
            this.fileDescriptionInformationLabel.Text = "  ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Update Version:";
            // 
            // updateVersionLabel
            // 
            this.updateVersionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateVersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.updateVersionLabel.Location = new System.Drawing.Point(104, 87);
            this.updateVersionLabel.Name = "updateVersionLabel";
            this.updateVersionLabel.Size = new System.Drawing.Size(728, 13);
            this.updateVersionLabel.TabIndex = 17;
            this.updateVersionLabel.Text = "  ";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBar.Location = new System.Drawing.Point(105, 156);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(725, 13);
            this.progressBar.Step = 5;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Update Info:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Size:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Status:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Progress:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "File:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "App Version:";
            // 
            // updateInformationLabel
            // 
            this.updateInformationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateInformationLabel.BackColor = System.Drawing.Color.Transparent;
            this.updateInformationLabel.Location = new System.Drawing.Point(104, 227);
            this.updateInformationLabel.Name = "updateInformationLabel";
            this.updateInformationLabel.Size = new System.Drawing.Size(728, 13);
            this.updateInformationLabel.TabIndex = 5;
            this.updateInformationLabel.Text = "  ";
            // 
            // totalSizeLabel
            // 
            this.totalSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalSizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalSizeLabel.Location = new System.Drawing.Point(104, 204);
            this.totalSizeLabel.Name = "totalSizeLabel";
            this.totalSizeLabel.Size = new System.Drawing.Size(728, 13);
            this.totalSizeLabel.TabIndex = 4;
            this.totalSizeLabel.Text = "  ";
            // 
            // receivedLabel
            // 
            this.receivedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.receivedLabel.BackColor = System.Drawing.Color.Transparent;
            this.receivedLabel.Location = new System.Drawing.Point(104, 180);
            this.receivedLabel.Name = "receivedLabel";
            this.receivedLabel.Size = new System.Drawing.Size(728, 13);
            this.receivedLabel.TabIndex = 3;
            this.receivedLabel.Text = "  ";
            // 
            // fileInformationLabel
            // 
            this.fileInformationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileInformationLabel.BackColor = System.Drawing.Color.Transparent;
            this.fileInformationLabel.Location = new System.Drawing.Point(104, 118);
            this.fileInformationLabel.Name = "fileInformationLabel";
            this.fileInformationLabel.Size = new System.Drawing.Size(728, 13);
            this.fileInformationLabel.TabIndex = 1;
            this.fileInformationLabel.Text = "  ";
            // 
            // applicationVersionLabel
            // 
            this.applicationVersionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.applicationVersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.applicationVersionLabel.Location = new System.Drawing.Point(104, 69);
            this.applicationVersionLabel.Name = "applicationVersionLabel";
            this.applicationVersionLabel.Size = new System.Drawing.Size(728, 13);
            this.applicationVersionLabel.TabIndex = 0;
            this.applicationVersionLabel.Text = "  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(102, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "NightBitsUpdater can update your c# application";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "NightBitsUpdater";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(848, 66);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // productURLLabel
            // 
            this.productURLLabel.AutoSize = true;
            this.productURLLabel.Location = new System.Drawing.Point(102, 102);
            this.productURLLabel.Name = "productURLLabel";
            this.productURLLabel.Size = new System.Drawing.Size(0, 13);
            this.productURLLabel.TabIndex = 21;
            this.productURLLabel.Click += new System.EventHandler(this.lnkInfo_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 271);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "More Information:";
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(15, 289);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(817, 238);
            this.webBrowser.TabIndex = 15;
            // 
            // errorLabel
            // 
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(104, 246);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(728, 16);
            this.errorLabel.TabIndex = 13;
            // 
            // percentageLabel
            // 
            this.percentageLabel.BackColor = System.Drawing.Color.Beige;
            this.percentageLabel.Location = new System.Drawing.Point(109, 156);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(33, 13);
            this.percentageLabel.TabIndex = 2;
            this.percentageLabel.Text = "  ";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(514, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Use the internalUpdater Forms";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AutoNightBitsUpdater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(848, 539);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.productURLLabel);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.fileDescriptionInformationLabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.updateVersionLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.updateInformationLabel);
            this.Controls.Add(this.totalSizeLabel);
            this.Controls.Add(this.receivedLabel);
            this.Controls.Add(this.percentageLabel);
            this.Controls.Add(this.fileInformationLabel);
            this.Controls.Add(this.applicationVersionLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AutoNightBitsUpdater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NightBitsUpdater example";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProgressView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label fileDescriptionInformationLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label updateVersionLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label updateInformationLabel;
        private System.Windows.Forms.Label totalSizeLabel;
        private System.Windows.Forms.Label receivedLabel;
        private System.Windows.Forms.Label fileInformationLabel;
        private System.Windows.Forms.Label applicationVersionLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel productURLLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label percentageLabel;
        private System.Windows.Forms.Button button1;
    }
}