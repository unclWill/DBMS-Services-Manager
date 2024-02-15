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
            lblDeveloperRepositories = new System.Windows.Forms.LinkLabel();
            lblDeveloperEmail = new System.Windows.Forms.LinkLabel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            LblCopyright = new System.Windows.Forms.Label();
            lblVersion = new System.Windows.Forms.Label();
            lblDescription = new System.Windows.Forms.Label();
            lblDeveloperName = new System.Windows.Forms.Label();
            lblProgramName = new System.Windows.Forms.Label();
            pbIcon = new System.Windows.Forms.PictureBox();
            pnlFooter = new System.Windows.Forms.Panel();
            btnClose = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcon).BeginInit();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBackground
            // 
            pnlBackground.BackgroundImage = Properties.Resources.SiSCC_AboutBackground;
            pnlBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pnlBackground.Controls.Add(lblDeveloperRepositories);
            pnlBackground.Controls.Add(lblDeveloperEmail);
            pnlBackground.Controls.Add(label1);
            pnlBackground.Controls.Add(label2);
            pnlBackground.Controls.Add(label3);
            pnlBackground.Controls.Add(label4);
            pnlBackground.Controls.Add(LblCopyright);
            pnlBackground.Controls.Add(lblVersion);
            pnlBackground.Controls.Add(lblDescription);
            pnlBackground.Controls.Add(lblDeveloperName);
            pnlBackground.Controls.Add(lblProgramName);
            pnlBackground.Controls.Add(pbIcon);
            pnlBackground.Location = new System.Drawing.Point(6, 10);
            pnlBackground.Name = "pnlBackground";
            pnlBackground.Size = new System.Drawing.Size(442, 293);
            pnlBackground.TabIndex = 0;
            // 
            // lblDeveloperRepositories
            // 
            lblDeveloperRepositories.AutoSize = true;
            lblDeveloperRepositories.BackColor = System.Drawing.Color.Transparent;
            lblDeveloperRepositories.Location = new System.Drawing.Point(134, 187);
            lblDeveloperRepositories.Name = "lblDeveloperRepositories";
            lblDeveloperRepositories.Size = new System.Drawing.Size(148, 15);
            lblDeveloperRepositories.TabIndex = 9;
            lblDeveloperRepositories.TabStop = true;
            lblDeveloperRepositories.Text = "DEVELOPER_REPOSITORIES";
            // 
            // lblDeveloperEmail
            // 
            lblDeveloperEmail.AutoSize = true;
            lblDeveloperEmail.BackColor = System.Drawing.Color.Transparent;
            lblDeveloperEmail.Location = new System.Drawing.Point(134, 214);
            lblDeveloperEmail.Name = "lblDeveloperEmail";
            lblDeveloperEmail.Size = new System.Drawing.Size(108, 15);
            lblDeveloperEmail.TabIndex = 8;
            lblDeveloperEmail.TabStop = true;
            lblDeveloperEmail.Text = "DEVELOPER_EMAIL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label1.Location = new System.Drawing.Point(83, 123);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(41, 15);
            label1.TabIndex = 2;
            label1.Text = "Versão";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label2.Location = new System.Drawing.Point(25, 160);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 15);
            label2.TabIndex = 3;
            label2.Text = "Desenvolvido por";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label3.Location = new System.Drawing.Point(57, 187);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(67, 15);
            label3.TabIndex = 4;
            label3.Text = "Repositório";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label4.Location = new System.Drawing.Point(74, 214);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(50, 15);
            label4.TabIndex = 5;
            label4.Text = "Contato";
            // 
            // LblCopyright
            // 
            LblCopyright.AutoSize = true;
            LblCopyright.BackColor = System.Drawing.Color.Transparent;
            LblCopyright.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LblCopyright.ForeColor = System.Drawing.SystemColors.ControlLight;
            LblCopyright.Location = new System.Drawing.Point(71, 263);
            LblCopyright.Name = "LblCopyright";
            LblCopyright.Size = new System.Drawing.Size(110, 17);
            LblCopyright.TabIndex = 7;
            LblCopyright.Text = "COPYRIGHT_TEXT";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.BackColor = System.Drawing.Color.Transparent;
            lblVersion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblVersion.Location = new System.Drawing.Point(133, 123);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new System.Drawing.Size(57, 15);
            lblVersion.TabIndex = 6;
            lblVersion.Text = "VERSION";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = System.Drawing.Color.Transparent;
            lblDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDescription.Location = new System.Drawing.Point(111, 84);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(83, 15);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "DESCRIPTION";
            // 
            // lblDeveloperName
            // 
            lblDeveloperName.AutoSize = true;
            lblDeveloperName.BackColor = System.Drawing.Color.Transparent;
            lblDeveloperName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDeveloperName.Location = new System.Drawing.Point(133, 160);
            lblDeveloperName.Name = "lblDeveloperName";
            lblDeveloperName.Size = new System.Drawing.Size(110, 15);
            lblDeveloperName.TabIndex = 2;
            lblDeveloperName.Text = "DEVELOPER_NAME";
            // 
            // lblProgramName
            // 
            lblProgramName.AutoSize = true;
            lblProgramName.BackColor = System.Drawing.Color.Transparent;
            lblProgramName.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblProgramName.Location = new System.Drawing.Point(142, 42);
            lblProgramName.Name = "lblProgramName";
            lblProgramName.Size = new System.Drawing.Size(175, 27);
            lblProgramName.TabIndex = 1;
            lblProgramName.Text = "PROGRAM_NAME";
            // 
            // pbIcon
            // 
            pbIcon.BackColor = System.Drawing.Color.Transparent;
            pbIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pbIcon.Image = (System.Drawing.Image)resources.GetObject("pbIcon.Image");
            pbIcon.Location = new System.Drawing.Point(25, 20);
            pbIcon.Name = "pbIcon";
            pbIcon.Size = new System.Drawing.Size(78, 79);
            pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbIcon.TabIndex = 0;
            pbIcon.TabStop = false;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = System.Drawing.Color.LightGray;
            pnlFooter.Controls.Add(btnClose);
            pnlFooter.Location = new System.Drawing.Point(-4, 302);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new System.Drawing.Size(461, 45);
            pnlFooter.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Snow;
            btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Linen;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnClose.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            btnClose.Location = new System.Drawing.Point(10, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(442, 26);
            btnClose.TabIndex = 8;
            btnClose.Text = "&Fechar";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            panel2.Location = new System.Drawing.Point(-4, -1);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(461, 305);
            panel2.TabIndex = 10;
            // 
            // FrmAbout
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(455, 343);
            Controls.Add(pnlBackground);
            Controls.Add(pnlFooter);
            Controls.Add(panel2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAbout";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Sobre";
            TopMost = true;
            Load += FrmAbout_Load;
            pnlBackground.ResumeLayout(false);
            pnlBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcon).EndInit();
            pnlFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lblDeveloperName;
        private System.Windows.Forms.Label LblCopyright;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel lblDeveloperEmail;
        private System.Windows.Forms.LinkLabel lblDeveloperRepositories;
        private System.Windows.Forms.Panel panel2;
    }
}