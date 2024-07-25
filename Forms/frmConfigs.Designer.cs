namespace MachineStop.Forms
{
    partial class FrmConfigs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfigs));
            tabConfigs = new System.Windows.Forms.TabControl();
            tpSQLServer = new System.Windows.Forms.TabPage();
            lblSQLServerServiceDisplayName = new System.Windows.Forms.Label();
            lblSQLServerMainService = new System.Windows.Forms.Label();
            txtSQLServerServiceDisplayName = new System.Windows.Forms.TextBox();
            txtSQLServerServiceName = new System.Windows.Forms.TextBox();
            tpMySQL = new System.Windows.Forms.TabPage();
            lblMySQLServiceDisplayName = new System.Windows.Forms.Label();
            lblMySQLMainService = new System.Windows.Forms.Label();
            txtMySQLServiceDisplayName = new System.Windows.Forms.TextBox();
            txtMySQLServiceName = new System.Windows.Forms.TextBox();
            tpPostgreSQL = new System.Windows.Forms.TabPage();
            lblPostgreSQLMainService = new System.Windows.Forms.Label();
            lblPostgreSQLServiceDisplayName = new System.Windows.Forms.Label();
            txtPostgreSQLServiceName = new System.Windows.Forms.TextBox();
            txtPostgreSQLServiceDisplayName = new System.Windows.Forms.TextBox();
            tpMariaDB = new System.Windows.Forms.TabPage();
            lblMariaDBMainService = new System.Windows.Forms.Label();
            lblMariaDBServiceDisplayName = new System.Windows.Forms.Label();
            txtMariaDBServiceName = new System.Windows.Forms.TextBox();
            txtMariaDBServiceDisplayName = new System.Windows.Forms.TextBox();
            tpMongoDB = new System.Windows.Forms.TabPage();
            lblMongoDBMainService = new System.Windows.Forms.Label();
            lblMongoDBServiceDisplayName = new System.Windows.Forms.Label();
            txtMongoDBServiceName = new System.Windows.Forms.TextBox();
            txtMongoDBServiceDisplayName = new System.Windows.Forms.TextBox();
            btnConfirm = new System.Windows.Forms.Button();
            btnEnableEdit = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            pnlFooter = new System.Windows.Forms.Panel();
            btnOpenServicesConsole = new System.Windows.Forms.Button();
            tabConfigs.SuspendLayout();
            tpSQLServer.SuspendLayout();
            tpMySQL.SuspendLayout();
            tpPostgreSQL.SuspendLayout();
            tpMariaDB.SuspendLayout();
            tpMongoDB.SuspendLayout();
            SuspendLayout();
            // 
            // tabConfigs
            // 
            tabConfigs.Anchor = System.Windows.Forms.AnchorStyles.None;
            tabConfigs.Controls.Add(tpSQLServer);
            tabConfigs.Controls.Add(tpMySQL);
            tabConfigs.Controls.Add(tpPostgreSQL);
            tabConfigs.Controls.Add(tpMariaDB);
            tabConfigs.Controls.Add(tpMongoDB);
            tabConfigs.Location = new System.Drawing.Point(12, 20);
            tabConfigs.Name = "tabConfigs";
            tabConfigs.SelectedIndex = 0;
            tabConfigs.Size = new System.Drawing.Size(450, 177);
            tabConfigs.TabIndex = 0;
            // 
            // tpSQLServer
            // 
            tpSQLServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            tpSQLServer.Controls.Add(lblSQLServerServiceDisplayName);
            tpSQLServer.Controls.Add(lblSQLServerMainService);
            tpSQLServer.Controls.Add(txtSQLServerServiceDisplayName);
            tpSQLServer.Controls.Add(txtSQLServerServiceName);
            tpSQLServer.Location = new System.Drawing.Point(4, 24);
            tpSQLServer.Name = "tpSQLServer";
            tpSQLServer.Padding = new System.Windows.Forms.Padding(3);
            tpSQLServer.Size = new System.Drawing.Size(442, 149);
            tpSQLServer.TabIndex = 0;
            tpSQLServer.Text = "SQL Server";
            tpSQLServer.UseVisualStyleBackColor = true;
            // 
            // lblSQLServerServiceDisplayName
            // 
            lblSQLServerServiceDisplayName.AutoSize = true;
            lblSQLServerServiceDisplayName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblSQLServerServiceDisplayName.Location = new System.Drawing.Point(203, 20);
            lblSQLServerServiceDisplayName.Name = "lblSQLServerServiceDisplayName";
            lblSQLServerServiceDisplayName.Size = new System.Drawing.Size(36, 15);
            lblSQLServerServiceDisplayName.TabIndex = 3;
            lblSQLServerServiceDisplayName.Text = "SGBD";
            // 
            // lblSQLServerMainService
            // 
            lblSQLServerMainService.AutoSize = true;
            lblSQLServerMainService.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblSQLServerMainService.Location = new System.Drawing.Point(172, 80);
            lblSQLServerMainService.Name = "lblSQLServerMainService";
            lblSQLServerMainService.Size = new System.Drawing.Size(98, 15);
            lblSQLServerMainService.TabIndex = 3;
            lblSQLServerMainService.Text = "Nome do Serviço";
            // 
            // txtSQLServerServiceDisplayName
            // 
            txtSQLServerServiceDisplayName.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSQLServerServiceDisplayName.Location = new System.Drawing.Point(6, 38);
            txtSQLServerServiceDisplayName.Name = "txtSQLServerServiceDisplayName";
            txtSQLServerServiceDisplayName.ReadOnly = true;
            txtSQLServerServiceDisplayName.Size = new System.Drawing.Size(430, 29);
            txtSQLServerServiceDisplayName.TabIndex = 2;
            txtSQLServerServiceDisplayName.Text = "SQL Server";
            txtSQLServerServiceDisplayName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSQLServerServiceName
            // 
            txtSQLServerServiceName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtSQLServerServiceName.Location = new System.Drawing.Point(6, 98);
            txtSQLServerServiceName.Name = "txtSQLServerServiceName";
            txtSQLServerServiceName.ReadOnly = true;
            txtSQLServerServiceName.Size = new System.Drawing.Size(430, 29);
            txtSQLServerServiceName.TabIndex = 2;
            txtSQLServerServiceName.Text = "MSSQL$SQLEXPRESS";
            txtSQLServerServiceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tpMySQL
            // 
            tpMySQL.Controls.Add(lblMySQLServiceDisplayName);
            tpMySQL.Controls.Add(lblMySQLMainService);
            tpMySQL.Controls.Add(txtMySQLServiceDisplayName);
            tpMySQL.Controls.Add(txtMySQLServiceName);
            tpMySQL.Location = new System.Drawing.Point(4, 24);
            tpMySQL.Name = "tpMySQL";
            tpMySQL.Padding = new System.Windows.Forms.Padding(3);
            tpMySQL.Size = new System.Drawing.Size(442, 149);
            tpMySQL.TabIndex = 1;
            tpMySQL.Text = "MySQL";
            tpMySQL.UseVisualStyleBackColor = true;
            // 
            // lblMySQLServiceDisplayName
            // 
            lblMySQLServiceDisplayName.AutoSize = true;
            lblMySQLServiceDisplayName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblMySQLServiceDisplayName.Location = new System.Drawing.Point(203, 20);
            lblMySQLServiceDisplayName.Name = "lblMySQLServiceDisplayName";
            lblMySQLServiceDisplayName.Size = new System.Drawing.Size(36, 15);
            lblMySQLServiceDisplayName.TabIndex = 9;
            lblMySQLServiceDisplayName.Text = "SGBD";
            // 
            // lblMySQLMainService
            // 
            lblMySQLMainService.AutoSize = true;
            lblMySQLMainService.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblMySQLMainService.Location = new System.Drawing.Point(172, 80);
            lblMySQLMainService.Name = "lblMySQLMainService";
            lblMySQLMainService.Size = new System.Drawing.Size(98, 15);
            lblMySQLMainService.TabIndex = 10;
            lblMySQLMainService.Text = "Nome do Serviço";
            // 
            // txtMySQLServiceDisplayName
            // 
            txtMySQLServiceDisplayName.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtMySQLServiceDisplayName.Location = new System.Drawing.Point(6, 38);
            txtMySQLServiceDisplayName.Name = "txtMySQLServiceDisplayName";
            txtMySQLServiceDisplayName.ReadOnly = true;
            txtMySQLServiceDisplayName.Size = new System.Drawing.Size(430, 29);
            txtMySQLServiceDisplayName.TabIndex = 6;
            txtMySQLServiceDisplayName.Text = "MySQL";
            txtMySQLServiceDisplayName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMySQLServiceName
            // 
            txtMySQLServiceName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtMySQLServiceName.Location = new System.Drawing.Point(6, 98);
            txtMySQLServiceName.Name = "txtMySQLServiceName";
            txtMySQLServiceName.ReadOnly = true;
            txtMySQLServiceName.Size = new System.Drawing.Size(430, 29);
            txtMySQLServiceName.TabIndex = 2;
            txtMySQLServiceName.Text = "MySQL80";
            txtMySQLServiceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tpPostgreSQL
            // 
            tpPostgreSQL.Controls.Add(lblPostgreSQLMainService);
            tpPostgreSQL.Controls.Add(lblPostgreSQLServiceDisplayName);
            tpPostgreSQL.Controls.Add(txtPostgreSQLServiceName);
            tpPostgreSQL.Controls.Add(txtPostgreSQLServiceDisplayName);
            tpPostgreSQL.Location = new System.Drawing.Point(4, 24);
            tpPostgreSQL.Name = "tpPostgreSQL";
            tpPostgreSQL.Size = new System.Drawing.Size(442, 149);
            tpPostgreSQL.TabIndex = 2;
            tpPostgreSQL.Text = "PostgreSQL";
            tpPostgreSQL.UseVisualStyleBackColor = true;
            // 
            // lblPostgreSQLMainService
            // 
            lblPostgreSQLMainService.AutoSize = true;
            lblPostgreSQLMainService.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblPostgreSQLMainService.Location = new System.Drawing.Point(172, 80);
            lblPostgreSQLMainService.Name = "lblPostgreSQLMainService";
            lblPostgreSQLMainService.Size = new System.Drawing.Size(98, 15);
            lblPostgreSQLMainService.TabIndex = 16;
            lblPostgreSQLMainService.Text = "Nome do Serviço";
            // 
            // lblPostgreSQLServiceDisplayName
            // 
            lblPostgreSQLServiceDisplayName.AutoSize = true;
            lblPostgreSQLServiceDisplayName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblPostgreSQLServiceDisplayName.Location = new System.Drawing.Point(203, 20);
            lblPostgreSQLServiceDisplayName.Name = "lblPostgreSQLServiceDisplayName";
            lblPostgreSQLServiceDisplayName.Size = new System.Drawing.Size(36, 15);
            lblPostgreSQLServiceDisplayName.TabIndex = 17;
            lblPostgreSQLServiceDisplayName.Text = "SGBD";
            // 
            // txtPostgreSQLServiceName
            // 
            txtPostgreSQLServiceName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtPostgreSQLServiceName.Location = new System.Drawing.Point(6, 98);
            txtPostgreSQLServiceName.Name = "txtPostgreSQLServiceName";
            txtPostgreSQLServiceName.ReadOnly = true;
            txtPostgreSQLServiceName.Size = new System.Drawing.Size(430, 29);
            txtPostgreSQLServiceName.TabIndex = 13;
            txtPostgreSQLServiceName.Text = "postgresql-x64-16";
            txtPostgreSQLServiceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPostgreSQLServiceDisplayName
            // 
            txtPostgreSQLServiceDisplayName.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPostgreSQLServiceDisplayName.Location = new System.Drawing.Point(6, 38);
            txtPostgreSQLServiceDisplayName.Name = "txtPostgreSQLServiceDisplayName";
            txtPostgreSQLServiceDisplayName.ReadOnly = true;
            txtPostgreSQLServiceDisplayName.Size = new System.Drawing.Size(430, 29);
            txtPostgreSQLServiceDisplayName.TabIndex = 2;
            txtPostgreSQLServiceDisplayName.Text = "PostgreSQL";
            txtPostgreSQLServiceDisplayName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tpMariaDB
            // 
            tpMariaDB.Controls.Add(lblMariaDBMainService);
            tpMariaDB.Controls.Add(lblMariaDBServiceDisplayName);
            tpMariaDB.Controls.Add(txtMariaDBServiceName);
            tpMariaDB.Controls.Add(txtMariaDBServiceDisplayName);
            tpMariaDB.Location = new System.Drawing.Point(4, 24);
            tpMariaDB.Name = "tpMariaDB";
            tpMariaDB.Size = new System.Drawing.Size(442, 149);
            tpMariaDB.TabIndex = 3;
            tpMariaDB.Text = "MariaDB";
            tpMariaDB.UseVisualStyleBackColor = true;
            // 
            // lblMariaDBMainService
            // 
            lblMariaDBMainService.AutoSize = true;
            lblMariaDBMainService.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblMariaDBMainService.Location = new System.Drawing.Point(172, 80);
            lblMariaDBMainService.Name = "lblMariaDBMainService";
            lblMariaDBMainService.Size = new System.Drawing.Size(98, 15);
            lblMariaDBMainService.TabIndex = 16;
            lblMariaDBMainService.Text = "Nome do Serviço";
            // 
            // lblMariaDBServiceDisplayName
            // 
            lblMariaDBServiceDisplayName.AutoSize = true;
            lblMariaDBServiceDisplayName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblMariaDBServiceDisplayName.Location = new System.Drawing.Point(203, 20);
            lblMariaDBServiceDisplayName.Name = "lblMariaDBServiceDisplayName";
            lblMariaDBServiceDisplayName.Size = new System.Drawing.Size(36, 15);
            lblMariaDBServiceDisplayName.TabIndex = 17;
            lblMariaDBServiceDisplayName.Text = "SGBD";
            // 
            // txtMariaDBServiceName
            // 
            txtMariaDBServiceName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtMariaDBServiceName.Location = new System.Drawing.Point(6, 98);
            txtMariaDBServiceName.Name = "txtMariaDBServiceName";
            txtMariaDBServiceName.ReadOnly = true;
            txtMariaDBServiceName.Size = new System.Drawing.Size(430, 29);
            txtMariaDBServiceName.TabIndex = 13;
            txtMariaDBServiceName.Text = "mariadb";
            txtMariaDBServiceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMariaDBServiceDisplayName
            // 
            txtMariaDBServiceDisplayName.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtMariaDBServiceDisplayName.Location = new System.Drawing.Point(6, 38);
            txtMariaDBServiceDisplayName.Name = "txtMariaDBServiceDisplayName";
            txtMariaDBServiceDisplayName.ReadOnly = true;
            txtMariaDBServiceDisplayName.Size = new System.Drawing.Size(430, 29);
            txtMariaDBServiceDisplayName.TabIndex = 2;
            txtMariaDBServiceDisplayName.Text = "MariaDB";
            txtMariaDBServiceDisplayName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tpMongoDB
            // 
            tpMongoDB.Controls.Add(lblMongoDBMainService);
            tpMongoDB.Controls.Add(lblMongoDBServiceDisplayName);
            tpMongoDB.Controls.Add(txtMongoDBServiceName);
            tpMongoDB.Controls.Add(txtMongoDBServiceDisplayName);
            tpMongoDB.Location = new System.Drawing.Point(4, 24);
            tpMongoDB.Name = "tpMongoDB";
            tpMongoDB.Size = new System.Drawing.Size(442, 149);
            tpMongoDB.TabIndex = 4;
            tpMongoDB.Text = "MongoDB";
            tpMongoDB.UseVisualStyleBackColor = true;
            // 
            // lblMongoDBMainService
            // 
            lblMongoDBMainService.AutoSize = true;
            lblMongoDBMainService.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblMongoDBMainService.Location = new System.Drawing.Point(172, 80);
            lblMongoDBMainService.Name = "lblMongoDBMainService";
            lblMongoDBMainService.Size = new System.Drawing.Size(98, 15);
            lblMongoDBMainService.TabIndex = 16;
            lblMongoDBMainService.Text = "Nome do Serviço";
            // 
            // lblMongoDBServiceDisplayName
            // 
            lblMongoDBServiceDisplayName.AutoSize = true;
            lblMongoDBServiceDisplayName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblMongoDBServiceDisplayName.Location = new System.Drawing.Point(203, 20);
            lblMongoDBServiceDisplayName.Name = "lblMongoDBServiceDisplayName";
            lblMongoDBServiceDisplayName.Size = new System.Drawing.Size(36, 15);
            lblMongoDBServiceDisplayName.TabIndex = 17;
            lblMongoDBServiceDisplayName.Text = "SGBD";
            // 
            // txtMongoDBServiceName
            // 
            txtMongoDBServiceName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtMongoDBServiceName.Location = new System.Drawing.Point(6, 98);
            txtMongoDBServiceName.Name = "txtMongoDBServiceName";
            txtMongoDBServiceName.ReadOnly = true;
            txtMongoDBServiceName.Size = new System.Drawing.Size(430, 29);
            txtMongoDBServiceName.TabIndex = 13;
            txtMongoDBServiceName.Text = "MongoDB";
            txtMongoDBServiceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMongoDBServiceDisplayName
            // 
            txtMongoDBServiceDisplayName.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtMongoDBServiceDisplayName.Location = new System.Drawing.Point(6, 38);
            txtMongoDBServiceDisplayName.Name = "txtMongoDBServiceDisplayName";
            txtMongoDBServiceDisplayName.ReadOnly = true;
            txtMongoDBServiceDisplayName.Size = new System.Drawing.Size(430, 29);
            txtMongoDBServiceDisplayName.TabIndex = 2;
            txtMongoDBServiceDisplayName.Text = "MongoDB";
            txtMongoDBServiceDisplayName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnConfirm.Image = (System.Drawing.Image)resources.GetObject("btnConfirm.Image");
            btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnConfirm.Location = new System.Drawing.Point(13, 205);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new System.Drawing.Size(184, 38);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "Confirmar alterações";
            btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnEnableEdit
            // 
            btnEnableEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnEnableEdit.Image = DBMS_Services_Manager.Properties.Resources.Sync;
            btnEnableEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnEnableEdit.Location = new System.Drawing.Point(12, 205);
            btnEnableEdit.Name = "btnEnableEdit";
            btnEnableEdit.Size = new System.Drawing.Size(184, 38);
            btnEnableEdit.TabIndex = 18;
            btnEnableEdit.Text = "Alterar parâmetros";
            btnEnableEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnEnableEdit.UseVisualStyleBackColor = true;
            btnEnableEdit.Click += btnEnableEdit_Click;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Snow;
            btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Linen;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnClose.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnClose.Location = new System.Drawing.Point(13, 275);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(449, 26);
            btnClose.TabIndex = 1;
            btnClose.Text = "&Fechar";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = System.Drawing.Color.LightGray;
            pnlFooter.Location = new System.Drawing.Point(-3, 263);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new System.Drawing.Size(480, 51);
            pnlFooter.TabIndex = 19;
            // 
            // btnOpenServicesConsole
            // 
            btnOpenServicesConsole.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnOpenServicesConsole.Image = DBMS_Services_Manager.Properties.Resources.Tune;
            btnOpenServicesConsole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnOpenServicesConsole.Location = new System.Drawing.Point(274, 205);
            btnOpenServicesConsole.Name = "btnOpenServicesConsole";
            btnOpenServicesConsole.Size = new System.Drawing.Size(184, 38);
            btnOpenServicesConsole.TabIndex = 18;
            btnOpenServicesConsole.Text = "Console de Serviços";
            btnOpenServicesConsole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnOpenServicesConsole.UseVisualStyleBackColor = true;
            btnOpenServicesConsole.Click += btnOpenServicesConsole_Click;
            // 
            // FrmConfigs
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = DBMS_Services_Manager.Properties.Resources.SiSCC_AboutBackground;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(474, 313);
            Controls.Add(btnOpenServicesConsole);
            Controls.Add(btnEnableEdit);
            Controls.Add(btnClose);
            Controls.Add(btnConfirm);
            Controls.Add(tabConfigs);
            Controls.Add(pnlFooter);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmConfigs";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Configurações dos serviços";
            Load += FrmConfigs_Load;
            tabConfigs.ResumeLayout(false);
            tpSQLServer.ResumeLayout(false);
            tpSQLServer.PerformLayout();
            tpMySQL.ResumeLayout(false);
            tpMySQL.PerformLayout();
            tpPostgreSQL.ResumeLayout(false);
            tpPostgreSQL.PerformLayout();
            tpMariaDB.ResumeLayout(false);
            tpMariaDB.PerformLayout();
            tpMongoDB.ResumeLayout(false);
            tpMongoDB.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btnConfirm;
        public System.Windows.Forms.TextBox txtMariaDBServiceDisplayName;
        public System.Windows.Forms.TabPage tpSQLServer;
        public System.Windows.Forms.TabPage tpMySQL;
        public System.Windows.Forms.TabPage tpPostgreSQL;
        public System.Windows.Forms.TabPage tpMariaDB;
        public System.Windows.Forms.TabPage tpMongoDB;
        private System.Windows.Forms.Label lblSQLServerServiceDisplayName;
        private System.Windows.Forms.Label lblSQLServerMainService;
        private System.Windows.Forms.Label lblMySQLServiceDisplayName;
        private System.Windows.Forms.Label lblMySQLMainService;
        private System.Windows.Forms.Label lblPostgreSQLMainService;
        private System.Windows.Forms.Label lblPostgreSQLServiceDisplayName;
        private System.Windows.Forms.Label lblMariaDBMainService;
        private System.Windows.Forms.Label lblMariaDBServiceDisplayName;
        private System.Windows.Forms.Button btnEnableEdit;
        private System.Windows.Forms.Label lblMongoDBMainService;
        private System.Windows.Forms.Label lblMongoDBServiceDisplayName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.TextBox txtSQLServerServiceName;
        private System.Windows.Forms.TextBox txtMySQLServiceName;
        private System.Windows.Forms.TextBox txtPostgreSQLServiceName;
        private System.Windows.Forms.TextBox txtMariaDBServiceName;
        private System.Windows.Forms.TextBox txtMongoDBServiceName;
        private System.Windows.Forms.TextBox txtPostgreSQLServiceDisplayName;
        private System.Windows.Forms.TextBox txtMongoDBServiceDisplayName;
        private System.Windows.Forms.TabControl tabConfigs;
        private System.Windows.Forms.TextBox txtSQLServerServiceDisplayName;
        private System.Windows.Forms.TextBox txtMySQLServiceDisplayName;
        private System.Windows.Forms.Button btnOpenServicesConsole;
    }
}