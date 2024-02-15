namespace DBMS_Services_Manager.Forms
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            pnlBackground = new System.Windows.Forms.Panel();
            pbIcon = new System.Windows.Forms.PictureBox();
            lblProgramName = new System.Windows.Forms.Label();
            lblDeveloperName = new System.Windows.Forms.Label();
            lblDescription = new System.Windows.Forms.Label();
            lblDeveloperRepositories = new System.Windows.Forms.Label();
            lblDeveloperEmail = new System.Windows.Forms.Label();
            lblVersion = new System.Windows.Forms.Label();
            LblCopyright = new System.Windows.Forms.Label();
            btnClose = new System.Windows.Forms.Button();
            pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcon).BeginInit();
            SuspendLayout();
            // 
            // pnlBackground
            // 
            pnlBackground.Controls.Add(LblCopyright);
            pnlBackground.Controls.Add(lblVersion);
            pnlBackground.Controls.Add(lblDeveloperEmail);
            pnlBackground.Controls.Add(lblDeveloperRepositories);
            pnlBackground.Controls.Add(lblDescription);
            pnlBackground.Controls.Add(lblDeveloperName);
            pnlBackground.Controls.Add(lblProgramName);
            pnlBackground.Controls.Add(pbIcon);
            pnlBackground.Location = new System.Drawing.Point(12, 12);
            pnlBackground.Name = "pnlBackground";
            pnlBackground.Size = new System.Drawing.Size(442, 296);
            pnlBackground.TabIndex = 0;
            // 
            // pbIcon
            // 
            pbIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pbIcon.Image = (System.Drawing.Image)resources.GetObject("pbIcon.Image");
            pbIcon.Location = new System.Drawing.Point(25, 20);
            pbIcon.Name = "pbIcon";
            pbIcon.Size = new System.Drawing.Size(100, 93);
            pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbIcon.TabIndex = 0;
            pbIcon.TabStop = false;
            // 
            // lblProgramName
            // 
            lblProgramName.AutoSize = true;
            lblProgramName.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblProgramName.Location = new System.Drawing.Point(163, 43);
            lblProgramName.Name = "lblProgramName";
            lblProgramName.Size = new System.Drawing.Size(175, 27);
            lblProgramName.TabIndex = 1;
            lblProgramName.Text = "PROGRAM_NAME";
            // 
            // lblDeveloperName
            // 
            lblDeveloperName.AutoSize = true;
            lblDeveloperName.Location = new System.Drawing.Point(25, 169);
            lblDeveloperName.Name = "lblDeveloperName";
            lblDeveloperName.Size = new System.Drawing.Size(108, 15);
            lblDeveloperName.TabIndex = 2;
            lblDeveloperName.Text = "DEVELOPER_NAME";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new System.Drawing.Point(163, 83);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(79, 15);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "DESCRIPTION";
            // 
            // lblDeveloperRepositories
            // 
            lblDeveloperRepositories.AutoSize = true;
            lblDeveloperRepositories.Location = new System.Drawing.Point(25, 194);
            lblDeveloperRepositories.Name = "lblDeveloperRepositories";
            lblDeveloperRepositories.Size = new System.Drawing.Size(154, 15);
            lblDeveloperRepositories.TabIndex = 4;
            lblDeveloperRepositories.Text = "DEVELOPER_RESPOSITORIES";
            // 
            // lblDeveloperEmail
            // 
            lblDeveloperEmail.AutoSize = true;
            lblDeveloperEmail.Location = new System.Drawing.Point(25, 219);
            lblDeveloperEmail.Name = "lblDeveloperEmail";
            lblDeveloperEmail.Size = new System.Drawing.Size(108, 15);
            lblDeveloperEmail.TabIndex = 5;
            lblDeveloperEmail.Text = "DEVELOPER_EMAIL";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new System.Drawing.Point(163, 127);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new System.Drawing.Size(54, 15);
            lblVersion.TabIndex = 6;
            lblVersion.Text = "VERSION";
            // 
            // LblCopyright
            // 
            LblCopyright.AutoSize = true;
            LblCopyright.Location = new System.Drawing.Point(89, 260);
            LblCopyright.Name = "LblCopyright";
            LblCopyright.Size = new System.Drawing.Size(71, 15);
            LblCopyright.TabIndex = 7;
            LblCopyright.Text = "COPYRIGHT";
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(12, 313);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(442, 29);
            btnClose.TabIndex = 1;
            btnClose.Text = "Fechar";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // FrmAbout
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(465, 348);
            Controls.Add(btnClose);
            Controls.Add(pnlBackground);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAbout";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Sobre";
            TopMost = true;
            pnlBackground.ResumeLayout(false);
            pnlBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lblDeveloperName;
        private System.Windows.Forms.Label LblCopyright;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblDeveloperEmail;
        private System.Windows.Forms.Label lblDeveloperRepositories;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnClose;
    }
}