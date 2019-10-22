namespace CleanUpCSVFiles
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChoosenHoldingsLabel = new System.Windows.Forms.Label();
            this.holdingsFilesTitle = new System.Windows.Forms.Label();
            this.FolderChosenPath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChoosenSettingsFileLabel = new System.Windows.Forms.Label();
            this.StatusLabelText = new System.Windows.Forms.Label();
            this.ProcessFilesButton = new System.Windows.Forms.Button();
            this.ChooseSettingsBtn = new System.Windows.Forms.Button();
            this.ChooseHoldingsBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChoosenHoldingsLabel);
            this.groupBox1.Controls.Add(this.holdingsFilesTitle);
            this.groupBox1.Controls.Add(this.FolderChosenPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ChoosenSettingsFileLabel);
            this.groupBox1.Controls.Add(this.StatusLabelText);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 176);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // ChoosenHoldingsLabel
            // 
            this.ChoosenHoldingsLabel.Location = new System.Drawing.Point(10, 82);
            this.ChoosenHoldingsLabel.Name = "ChoosenHoldingsLabel";
            this.ChoosenHoldingsLabel.Size = new System.Drawing.Size(408, 13);
            this.ChoosenHoldingsLabel.TabIndex = 14;
            this.ChoosenHoldingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // holdingsFilesTitle
            // 
            this.holdingsFilesTitle.AutoSize = true;
            this.holdingsFilesTitle.Location = new System.Drawing.Point(9, 62);
            this.holdingsFilesTitle.Name = "holdingsFilesTitle";
            this.holdingsFilesTitle.Size = new System.Drawing.Size(67, 13);
            this.holdingsFilesTitle.TabIndex = 13;
            this.holdingsFilesTitle.Text = "Holding files:";
            // 
            // FolderChosenPath
            // 
            this.FolderChosenPath.AutoSize = true;
            this.FolderChosenPath.Location = new System.Drawing.Point(9, 16);
            this.FolderChosenPath.Name = "FolderChosenPath";
            this.FolderChosenPath.Size = new System.Drawing.Size(64, 13);
            this.FolderChosenPath.TabIndex = 11;
            this.FolderChosenPath.Text = "Settings file:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Status:";
            // 
            // ChoosenSettingsFileLabel
            // 
            this.ChoosenSettingsFileLabel.Location = new System.Drawing.Point(9, 40);
            this.ChoosenSettingsFileLabel.Name = "ChoosenSettingsFileLabel";
            this.ChoosenSettingsFileLabel.Size = new System.Drawing.Size(408, 13);
            this.ChoosenSettingsFileLabel.TabIndex = 12;
            this.ChoosenSettingsFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatusLabelText
            // 
            this.StatusLabelText.Location = new System.Drawing.Point(47, 150);
            this.StatusLabelText.Name = "StatusLabelText";
            this.StatusLabelText.Size = new System.Drawing.Size(160, 13);
            this.StatusLabelText.TabIndex = 10;
            // 
            // ProcessFilesButton
            // 
            this.ProcessFilesButton.Location = new System.Drawing.Point(335, 191);
            this.ProcessFilesButton.Name = "ProcessFilesButton";
            this.ProcessFilesButton.Size = new System.Drawing.Size(105, 25);
            this.ProcessFilesButton.TabIndex = 19;
            this.ProcessFilesButton.Text = "Process files";
            this.ProcessFilesButton.UseVisualStyleBackColor = true;
            this.ProcessFilesButton.Click += new System.EventHandler(this.ProcessFilesButton_Click);
            // 
            // ChooseSettingsBtn
            // 
            this.ChooseSettingsBtn.Location = new System.Drawing.Point(12, 192);
            this.ChooseSettingsBtn.Name = "ChooseSettingsBtn";
            this.ChooseSettingsBtn.Size = new System.Drawing.Size(105, 25);
            this.ChooseSettingsBtn.TabIndex = 18;
            this.ChooseSettingsBtn.Text = "Choose settings";
            this.ChooseSettingsBtn.UseVisualStyleBackColor = true;
            this.ChooseSettingsBtn.Click += new System.EventHandler(this.ChooseSettingsBtn_Click);
            // 
            // ChooseHoldingsBtn
            // 
            this.ChooseHoldingsBtn.Location = new System.Drawing.Point(123, 192);
            this.ChooseHoldingsBtn.Name = "ChooseHoldingsBtn";
            this.ChooseHoldingsBtn.Size = new System.Drawing.Size(105, 25);
            this.ChooseHoldingsBtn.TabIndex = 21;
            this.ChooseHoldingsBtn.Text = "Choose holdings";
            this.ChooseHoldingsBtn.UseVisualStyleBackColor = true;
            this.ChooseHoldingsBtn.Click += new System.EventHandler(this.ChooseHoldingsBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 223);
            this.Controls.Add(this.ChooseHoldingsBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ProcessFilesButton);
            this.Controls.Add(this.ChooseSettingsBtn);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label FolderChosenPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ChoosenSettingsFileLabel;
        private System.Windows.Forms.Label StatusLabelText;
        private System.Windows.Forms.Button ProcessFilesButton;
        private System.Windows.Forms.Button ChooseSettingsBtn;
        private System.Windows.Forms.Label holdingsFilesTitle;
        private System.Windows.Forms.Button ChooseHoldingsBtn;
        private System.Windows.Forms.Label ChoosenHoldingsLabel;
    }
}

