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
            lblSQLServerServiceName = new System.Windows.Forms.Label();
            lblSQLServerMainService = new System.Windows.Forms.Label();
            txtSQLServerServiceName = new System.Windows.Forms.TextBox();
            txtSQLServerProcessName = new System.Windows.Forms.TextBox();
            tpMySQL = new System.Windows.Forms.TabPage();
            lblMySQLServiceName = new System.Windows.Forms.Label();
            lblMySQLMainService = new System.Windows.Forms.Label();
            txtMySQLServiceName = new System.Windows.Forms.TextBox();
            txtMySQLProcessName = new System.Windows.Forms.TextBox();
            tpPostgreSQL = new System.Windows.Forms.TabPage();
            lblPostgreSQLMainService = new System.Windows.Forms.Label();
            lblPostgreSQLServiceName = new System.Windows.Forms.Label();
            txtPostgreSQLProcessName = new System.Windows.Forms.TextBox();
            txtPostgreSQLServiceName = new System.Windows.Forms.TextBox();
            tpMariaDB = new System.Windows.Forms.TabPage();
            lblMariaDBMainService = new System.Windows.Forms.Label();
            lblMariaDBServiceName = new System.Windows.Forms.Label();
            txtMariaDBProcessName = new System.Windows.Forms.TextBox();
            txtMariaDBServiceName = new System.Windows.Forms.TextBox();
            tpMongoDB = new System.Windows.Forms.TabPage();
            lblMongoDBMainService = new System.Windows.Forms.Label();
            lblMongoDBServiceName = new System.Windows.Forms.Label();
            txtMongoDBProcessName = new System.Windows.Forms.TextBox();
            txtMongoDBServiceName = new System.Windows.Forms.TextBox();
            btnConfirm = new System.Windows.Forms.Button();
            btnEnableEdit = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            pnlFooter = new System.Windows.Forms.Panel();
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
            tpSQLServer.Controls.Add(lblSQLServerServiceName);
            tpSQLServer.Controls.Add(lblSQLServerMainService);
            tpSQLServer.Controls.Add(txtSQLServerServiceName);
            tpSQLServer.Controls.Add(txtSQLServerProcessName);
            tpSQLServer.Location = new System.Drawing.Point(4, 24);
            tpSQLServer.Name = "tpSQLServer";
            tpSQLServer.Padding = new System.Windows.Forms.Padding(3);
            tpSQLServer.Size = new System.Drawing.Size(442, 149);
            tpSQLServer.TabIndex = 0;
            tpSQLServer.Text = "SQL Server";
            tpSQLServer.UseVisualStyleBackColor = true;
            // 
            // lblSQLServerServiceName
            // 
            lblSQLServerServiceName.AutoSize = true;
            lblSQLServerServiceName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblSQLServerServiceName.Location = new System.Drawing.Point(164, 20);
            lblSQLServerServiceName.Name = "lblSQLServerServiceName";
            lblSQLServerServiceName.Size = new System.Drawing.Size(111, 15);
            lblSQLServerServiceName.TabIndex = 3;
            lblSQLServerServiceName.Text = "NOME DO SERVIÇO";
            // 
            // lblSQLServerMainService
            // 
            lblSQLServerMainService.AutoSize = true;
            lblSQLServerMainService.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblSQLServerMainService.Location = new System.Drawing.Point(165, 80);
            lblSQLServerMainService.Name = "lblSQLServerMainService";
            lblSQLServerMainService.Size = new System.Drawing.Size(113, 15);
            lblSQLServerMainService.TabIndex = 3;
            lblSQLServerMainService.Text = "SERVIÇO PRINCIPAL";
            // 
            // txtSQLServerServiceName
            // 
            txtSQLServerServiceName.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSQLServerServiceName.Location = new System.Drawing.Point(6, 38);
            txtSQLServerServiceName.Name = "txtSQLServerServiceName";
            txtSQLServerServiceName.ReadOnly = true;
            txtSQLServerServiceName.Size = new System.Drawing.Size(430, 29);
            txtSQLServerServiceName.TabIndex = 2;
            txtSQLServerServiceName.Text = "SQL Server";
            txtSQLServerServiceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSQLServerProcessName
            // 
            txtSQLServerProcessName.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSQLServerProcessName.Location = new System.Drawing.Point(6, 98);
            txtSQLServerProcessName.Name = "txtSQLServerProcessName";
            txtSQLServerProcessName.ReadOnly = true;
            txtSQLServerProcessName.Size = new System.Drawing.Size(430, 29);
            txtSQLServerProcessName.TabIndex = 2;
            txtSQLServerProcessName.Text = "MSSQL$SQLEXPRESS";
            txtSQLServerProcessName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tpMySQL
            // 
            tpMySQL.Controls.Add(lblMySQLServiceName);
            tpMySQL.Controls.Add(lblMySQLMainService);
            tpMySQL.Controls.Add(txtMySQLServiceName);
            tpMySQL.Controls.Add(txtMySQLProcessName);
            tpMySQL.Location = new System.Drawing.Point(4, 24);
            tpMySQL.Name = "tpMySQL";
            tpMySQL.Padding = new System.Windows.Forms.Padding(3);
            tpMySQL.Size = new System.Drawing.Size(442, 149);
            tpMySQL.TabIndex = 1;
            tpMySQL.Text = "MySQL";
            tpMySQL.UseVisualStyleBackColor = true;
            // 
            // lblMySQLServiceName
            // 
            lblMySQLServiceName.AutoSize = true;
            lblMySQLServiceName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblMySQLServiceName.Location = new System.Drawing.Point(166, 20);
            lblMySQLServiceName.Name = "lblMySQLServiceName";
            lblMySQLServiceName.Size = new System.Drawing.Size(111, 15);
            lblMySQLServiceName.TabIndex = 9;
            lblMySQLServiceName.Text = "NOME DO SERVIÇO";
            // 
            // lblMySQLMainService
            // 
            lblMySQLMainService.AutoSize = true;
            lblMySQLMainService.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblMySQLMainService.Location = new System.Drawing.Point(165, 80);
            lblMySQLMainService.Name = "lblMySQLMainService";
            lblMySQLMainService.Size = new System.Drawing.Size(113, 15);
            lblMySQLMainService.TabIndex = 10;
            lblMySQLMainService.Text = "SERVIÇO PRINCIPAL";
            // 
            // txtMySQLServiceName
            // 
            txtMySQLServiceName.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtMySQLServiceName.Location = new System.Drawing.Point(6, 38);
            txtMySQLServiceName.Name = "txtMySQLServiceName";
            txtMySQLServiceName.ReadOnly = true;
            txtMySQLServiceName.Size = new System.Drawing.Size(430, 29);
            txtMySQLServiceName.TabIndex = 6;
            txtMySQLServiceName.Text = "MySQL";
            txtMySQLServiceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMySQLProcessName
            // 
            txtMySQLProcessName.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtMySQLProcessName.Location = new System.Drawing.Point(6, 98);
            txtMySQLProcessName.Name = "txtMySQLProcessName";
            txtMySQLProcessName.ReadOnly = true;
            txtMySQLProcessName.Size = new System.Drawing.Size(430, 29);
            txtMySQLProcessName.TabIndex = 2;
            txtMySQLProcessName.Text = "MySQL80";
            txtMySQLProcessName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tpPostgreSQL
            // 
            tpPostgreSQL.Controls.Add(lblPostgreSQLMainService);
            tpPostgreSQL.Controls.Add(lblPostgreSQLServiceName);
            tpPostgreSQL.Controls.Add(txtPostgreSQLProcessName);
            tpPostgreSQL.Controls.Add(txtPostgreSQLServiceName);
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
            lblPostgreSQLMainService.Location = new System.Drawing.Point(165, 80);
            lblPostgreSQLMainService.Name = "lblPostgreSQLMainService";
            lblPostgreSQLMainService.Size = new System.Drawing.Size(113, 15);
            lblPostgreSQLMainService.TabIndex = 16;
            lblPostgreSQLMainService.Text = "SERVIÇO PRINCIPAL";
            // 
            // lblPostgreSQLServiceName
            // 
            lblPostgreSQLServiceName.AutoSize = true;
            lblPostgreSQLServiceName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblPostgreSQLServiceName.Location = new System.Drawing.Point(165, 20);
            lblPostgreSQLServiceName.Name = "lblPostgreSQLServiceName";
            lblPostgreSQLServiceName.Size = new System.Drawing.Size(111, 15);
            lblPostgreSQLServiceName.TabIndex = 17;
            lblPostgreSQLServiceName.Text = "NOME DO SERVIÇO";
            // 
            // txtPostgreSQLProcessName
            // 
            txtPostgreSQLProcessName.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPostgreSQLProcessName.Location = new System.Drawing.Point(6, 98);
            txtPostgreSQLProcessName.Name = "txtPostgreSQLProcessName";
            txtPostgreSQLProcessName.ReadOnly = true;
            txtPostgreSQLProcessName.Size = new System.Drawing.Size(430, 29);
            txtPostgreSQLProcessName.TabIndex = 13;
            txtPostgreSQLProcessName.Text = "postgresql-x64-16";
            txtPostgreSQLProcessName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPostgreSQLServiceName
            // 
            txtPostgreSQLServiceName.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPostgreSQLServiceName.Location = new System.Drawing.Point(6, 38);
            txtPostgreSQLServiceName.Name = "txtPostgreSQLServiceName";
            txtPostgreSQLServiceName.ReadOnly = true;
            txtPostgreSQLServiceName.Size = new System.Drawing.Size(430, 29);
            txtPostgreSQLServiceName.TabIndex = 2;
            txtPostgreSQLServiceName.Text = "PostgreSQL";
            txtPostgreSQLServiceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tpMariaDB
            // 
            tpMariaDB.Controls.Add(lblMariaDBMainService);
            tpMariaDB.Controls.Add(lblMariaDBServiceName);
            tpMariaDB.Controls.Add(txtMariaDBProcessName);
            tpMariaDB.Controls.Add(txtMariaDBServiceName);
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
            lblMariaDBMainService.Location = new System.Drawing.Point(165, 80);
            lblMariaDBMainService.Name = "lblMariaDBMainService";
            lblMariaDBMainService.Size = new System.Drawing.Size(113, 15);
            lblMariaDBMainService.TabIndex = 16;
            lblMariaDBMainService.Text = "SERVIÇO PRINCIPAL";
            // 
            // lblMariaDBServiceName
            // 
            lblMariaDBServiceName.AutoSize = true;
            lblMariaDBServiceName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblMariaDBServiceName.Location = new System.Drawing.Point(165, 20);
            lblMariaDBServiceName.Name = "lblMariaDBServiceName";
            lblMariaDBServiceName.Size = new System.Drawing.Size(111, 15);
            lblMariaDBServiceName.TabIndex = 17;
            lblMariaDBServiceName.Text = "NOME DO SERVIÇO";
            // 
            // txtMariaDBProcessName
            // 
            txtMariaDBProcessName.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtMariaDBProcessName.Location = new System.Drawing.Point(6, 98);
            txtMariaDBProcessName.Name = "txtMariaDBProcessName";
            txtMariaDBProcessName.ReadOnly = true;
            txtMariaDBProcessName.Size = new System.Drawing.Size(430, 29);
            txtMariaDBProcessName.TabIndex = 13;
            txtMariaDBProcessName.Text = "mariadb";
            txtMariaDBProcessName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMariaDBServiceName
            // 
            txtMariaDBServiceName.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtMariaDBServiceName.Location = new System.Drawing.Point(6, 38);
            txtMariaDBServiceName.Name = "txtMariaDBServiceName";
            txtMariaDBServiceName.ReadOnly = true;
            txtMariaDBServiceName.Size = new System.Drawing.Size(430, 29);
            txtMariaDBServiceName.TabIndex = 2;
            txtMariaDBServiceName.Text = "MariaDB";
            txtMariaDBServiceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tpMongoDB
            // 
            tpMongoDB.Controls.Add(lblMongoDBMainService);
            tpMongoDB.Controls.Add(lblMongoDBServiceName);
            tpMongoDB.Controls.Add(txtMongoDBProcessName);
            tpMongoDB.Controls.Add(txtMongoDBServiceName);
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
            lblMongoDBMainService.Location = new System.Drawing.Point(165, 80);
            lblMongoDBMainService.Name = "lblMongoDBMainService";
            lblMongoDBMainService.Size = new System.Drawing.Size(113, 15);
            lblMongoDBMainService.TabIndex = 16;
            lblMongoDBMainService.Text = "SERVIÇO PRINCIPAL";
            // 
            // lblMongoDBServiceName
            // 
            lblMongoDBServiceName.AutoSize = true;
            lblMongoDBServiceName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblMongoDBServiceName.Location = new System.Drawing.Point(166, 20);
            lblMongoDBServiceName.Name = "lblMongoDBServiceName";
            lblMongoDBServiceName.Size = new System.Drawing.Size(111, 15);
            lblMongoDBServiceName.TabIndex = 17;
            lblMongoDBServiceName.Text = "NOME DO SERVIÇO";
            // 
            // txtMongoDBProcessName
            // 
            txtMongoDBProcessName.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtMongoDBProcessName.Location = new System.Drawing.Point(6, 98);
            txtMongoDBProcessName.Name = "txtMongoDBProcessName";
            txtMongoDBProcessName.ReadOnly = true;
            txtMongoDBProcessName.Size = new System.Drawing.Size(430, 29);
            txtMongoDBProcessName.TabIndex = 13;
            txtMongoDBProcessName.Text = "mongodb";
            txtMongoDBProcessName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMongoDBServiceName
            // 
            txtMongoDBServiceName.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtMongoDBServiceName.Location = new System.Drawing.Point(6, 38);
            txtMongoDBServiceName.Name = "txtMongoDBServiceName";
            txtMongoDBServiceName.ReadOnly = true;
            txtMongoDBServiceName.Size = new System.Drawing.Size(430, 29);
            txtMongoDBServiceName.TabIndex = 2;
            txtMongoDBServiceName.Text = "MongoDB";
            txtMongoDBServiceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnConfirm.Image = (System.Drawing.Image)resources.GetObject("btnConfirm.Image");
            btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnConfirm.Location = new System.Drawing.Point(12, 205);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new System.Drawing.Size(450, 38);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "Confirmar configurações";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnEnableEdit
            // 
            btnEnableEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnEnableEdit.Image = (System.Drawing.Image)resources.GetObject("btnEnableEdit.Image");
            btnEnableEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnEnableEdit.Location = new System.Drawing.Point(12, 205);
            btnEnableEdit.Name = "btnEnableEdit";
            btnEnableEdit.Size = new System.Drawing.Size(450, 38);
            btnEnableEdit.TabIndex = 18;
            btnEnableEdit.Text = "Alterar parâmetros";
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
            // FrmConfigs
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = DBMS_Services_Manager.Properties.Resources.SiSCC_AboutBackground;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(474, 313);
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
        public System.Windows.Forms.TextBox txtMariaDBServiceName;
        public System.Windows.Forms.TabPage tpSQLServer;
        public System.Windows.Forms.TabPage tpMySQL;
        public System.Windows.Forms.TabPage tpPostgreSQL;
        public System.Windows.Forms.TabPage tpMariaDB;
        public System.Windows.Forms.TabPage tpMongoDB;
        private System.Windows.Forms.Label lblSQLServerServiceName;
        private System.Windows.Forms.Label lblSQLServerMainService;
        private System.Windows.Forms.Label lblMySQLServiceName;
        private System.Windows.Forms.Label lblMySQLMainService;
        private System.Windows.Forms.Label lblPostgreSQLMainService;
        private System.Windows.Forms.Label lblPostgreSQLServiceName;
        private System.Windows.Forms.Label lblMariaDBMainService;
        private System.Windows.Forms.Label lblMariaDBServiceName;
        private System.Windows.Forms.Button btnEnableEdit;
        private System.Windows.Forms.Label lblMongoDBMainService;
        private System.Windows.Forms.Label lblMongoDBServiceName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.TextBox txtSQLServerProcessName;
        private System.Windows.Forms.TextBox txtMySQLProcessName;
        private System.Windows.Forms.TextBox txtPostgreSQLProcessName;
        private System.Windows.Forms.TextBox txtMariaDBProcessName;
        private System.Windows.Forms.TextBox txtMongoDBProcessName;
        private System.Windows.Forms.TextBox txtPostgreSQLServiceName;
        private System.Windows.Forms.TextBox txtMongoDBServiceName;
        private System.Windows.Forms.TabControl tabConfigs;
        private System.Windows.Forms.TextBox txtSQLServerServiceName;
        private System.Windows.Forms.TextBox txtMySQLServiceName;
    }
}