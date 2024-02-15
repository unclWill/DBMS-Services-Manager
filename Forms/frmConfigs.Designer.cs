namespace MachineStop.Forms
{
    partial class frmConfigs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigs));
            tabConfigs = new System.Windows.Forms.TabControl();
            tpSQLServer = new System.Windows.Forms.TabPage();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            txtSQLServerServiceName = new System.Windows.Forms.TextBox();
            txtSQLServerProcessName = new System.Windows.Forms.TextBox();
            tpMySQL = new System.Windows.Forms.TabPage();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            txtMySQLServiceName = new System.Windows.Forms.TextBox();
            txtMySQLProcessName = new System.Windows.Forms.TextBox();
            tpPostgreSQL = new System.Windows.Forms.TabPage();
            label3 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            txtPostgreSQLProcessName = new System.Windows.Forms.TextBox();
            txtPostgreSQLServiceName = new System.Windows.Forms.TextBox();
            tpMariaDB = new System.Windows.Forms.TabPage();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            txtMariaDBProcessName = new System.Windows.Forms.TextBox();
            txtMariaDBServiceName = new System.Windows.Forms.TextBox();
            tpMongoDB = new System.Windows.Forms.TabPage();
            label14 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            txtMongoDBProcessName = new System.Windows.Forms.TextBox();
            txtMongoDBServiceName = new System.Windows.Forms.TextBox();
            btnConfirm = new System.Windows.Forms.Button();
            btnEnableEdit = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
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
            tabConfigs.Location = new System.Drawing.Point(16, 14);
            tabConfigs.Name = "tabConfigs";
            tabConfigs.SelectedIndex = 0;
            tabConfigs.Size = new System.Drawing.Size(450, 182);
            tabConfigs.TabIndex = 0;
            // 
            // tpSQLServer
            // 
            tpSQLServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            tpSQLServer.Controls.Add(label7);
            tpSQLServer.Controls.Add(label6);
            tpSQLServer.Controls.Add(txtSQLServerServiceName);
            tpSQLServer.Controls.Add(txtSQLServerProcessName);
            tpSQLServer.Location = new System.Drawing.Point(4, 24);
            tpSQLServer.Name = "tpSQLServer";
            tpSQLServer.Padding = new System.Windows.Forms.Padding(3);
            tpSQLServer.Size = new System.Drawing.Size(442, 154);
            tpSQLServer.TabIndex = 0;
            tpSQLServer.Text = "SQL Server";
            tpSQLServer.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label7.Location = new System.Drawing.Point(6, 20);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(111, 15);
            label7.TabIndex = 3;
            label7.Text = "NOME DO SERVIÇO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label6.Location = new System.Drawing.Point(6, 80);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(113, 15);
            label6.TabIndex = 3;
            label6.Text = "SERVIÇO PRINCIPAL";
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
            tpMySQL.Controls.Add(label9);
            tpMySQL.Controls.Add(label10);
            tpMySQL.Controls.Add(txtMySQLServiceName);
            tpMySQL.Controls.Add(txtMySQLProcessName);
            tpMySQL.Location = new System.Drawing.Point(4, 24);
            tpMySQL.Name = "tpMySQL";
            tpMySQL.Padding = new System.Windows.Forms.Padding(3);
            tpMySQL.Size = new System.Drawing.Size(442, 154);
            tpMySQL.TabIndex = 1;
            tpMySQL.Text = "MySQL";
            tpMySQL.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label9.Location = new System.Drawing.Point(6, 20);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(111, 15);
            label9.TabIndex = 9;
            label9.Text = "NOME DO SERVIÇO";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label10.Location = new System.Drawing.Point(6, 80);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(113, 15);
            label10.TabIndex = 10;
            label10.Text = "SERVIÇO PRINCIPAL";
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
            tpPostgreSQL.Controls.Add(label3);
            tpPostgreSQL.Controls.Add(label11);
            tpPostgreSQL.Controls.Add(txtPostgreSQLProcessName);
            tpPostgreSQL.Controls.Add(txtPostgreSQLServiceName);
            tpPostgreSQL.Location = new System.Drawing.Point(4, 24);
            tpPostgreSQL.Name = "tpPostgreSQL";
            tpPostgreSQL.Size = new System.Drawing.Size(442, 154);
            tpPostgreSQL.TabIndex = 2;
            tpPostgreSQL.Text = "PostgreSQL";
            tpPostgreSQL.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label3.Location = new System.Drawing.Point(6, 80);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(113, 15);
            label3.TabIndex = 16;
            label3.Text = "SERVIÇO PRINCIPAL";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label11.Location = new System.Drawing.Point(6, 20);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(111, 15);
            label11.TabIndex = 17;
            label11.Text = "NOME DO SERVIÇO";
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
            tpMariaDB.Controls.Add(label12);
            tpMariaDB.Controls.Add(label13);
            tpMariaDB.Controls.Add(txtMariaDBProcessName);
            tpMariaDB.Controls.Add(txtMariaDBServiceName);
            tpMariaDB.Location = new System.Drawing.Point(4, 24);
            tpMariaDB.Name = "tpMariaDB";
            tpMariaDB.Size = new System.Drawing.Size(442, 154);
            tpMariaDB.TabIndex = 3;
            tpMariaDB.Text = "MariaDB";
            tpMariaDB.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label12.Location = new System.Drawing.Point(6, 80);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(113, 15);
            label12.TabIndex = 16;
            label12.Text = "SERVIÇO PRINCIPAL";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label13.Location = new System.Drawing.Point(6, 20);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(111, 15);
            label13.TabIndex = 17;
            label13.Text = "NOME DO SERVIÇO";
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
            tpMongoDB.Controls.Add(label14);
            tpMongoDB.Controls.Add(label15);
            tpMongoDB.Controls.Add(txtMongoDBProcessName);
            tpMongoDB.Controls.Add(txtMongoDBServiceName);
            tpMongoDB.Location = new System.Drawing.Point(4, 24);
            tpMongoDB.Name = "tpMongoDB";
            tpMongoDB.Size = new System.Drawing.Size(442, 154);
            tpMongoDB.TabIndex = 4;
            tpMongoDB.Text = "MongoDB";
            tpMongoDB.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label14.Location = new System.Drawing.Point(6, 80);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(113, 15);
            label14.TabIndex = 16;
            label14.Text = "SERVIÇO PRINCIPAL";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label15.Location = new System.Drawing.Point(6, 20);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(111, 15);
            label15.TabIndex = 17;
            label15.Text = "NOME DO SERVIÇO";
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
            btnConfirm.Image = (System.Drawing.Image)resources.GetObject("btnConfirm.Image");
            btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnConfirm.Location = new System.Drawing.Point(16, 200);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new System.Drawing.Size(442, 38);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "Confirmar configurações";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnEnableEdit
            // 
            btnEnableEdit.Image = (System.Drawing.Image)resources.GetObject("btnEnableEdit.Image");
            btnEnableEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnEnableEdit.Location = new System.Drawing.Point(16, 200);
            btnEnableEdit.Name = "btnEnableEdit";
            btnEnableEdit.Size = new System.Drawing.Size(442, 38);
            btnEnableEdit.TabIndex = 18;
            btnEnableEdit.Text = "Editar parâmetros";
            btnEnableEdit.UseVisualStyleBackColor = true;
            btnEnableEdit.Click += btnEnableEdit_Click;
            // 
            // btnClose
            // 
            btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnClose.Location = new System.Drawing.Point(13, 258);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(449, 33);
            btnClose.TabIndex = 1;
            btnClose.Text = "Fechar";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmConfigs
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(474, 301);
            ControlBox = false;
            Controls.Add(btnEnableEdit);
            Controls.Add(btnClose);
            Controls.Add(btnConfirm);
            Controls.Add(tabConfigs);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "frmConfigs";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Configurações dos serviços";
            TopMost = true;
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
        public System.Windows.Forms.TextBox txtPostgreSQLServiceName;
        public System.Windows.Forms.TextBox txtMySQLProcessName;
        public System.Windows.Forms.TextBox txtSQLServerProcessName;
        public System.Windows.Forms.TextBox txtMariaDBServiceName;
        public System.Windows.Forms.TextBox txtMongoDBServiceName;
        public System.Windows.Forms.TabControl tabConfigs;
        public System.Windows.Forms.TabPage tpSQLServer;
        public System.Windows.Forms.TabPage tpMySQL;
        public System.Windows.Forms.TabPage tpPostgreSQL;
        public System.Windows.Forms.TabPage tpMariaDB;
        public System.Windows.Forms.TabPage tpMongoDB;
        public System.Windows.Forms.TextBox txtSQLServerServiceName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtMySQLServiceName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtPostgreSQLProcessName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtMariaDBProcessName;
        private System.Windows.Forms.Button btnEnableEdit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox txtMongoDBProcessName;
        private System.Windows.Forms.Button btnClose;
    }
}