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
            this.tabConfigs = new System.Windows.Forms.TabControl();
            this.tpSQLServer = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSQLServerExtraService = new System.Windows.Forms.TextBox();
            this.txtSQLServerSecondaryService = new System.Windows.Forms.TextBox();
            this.txtSQLServerMainService = new System.Windows.Forms.TextBox();
            this.tpMySQL = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMySQLExtraService = new System.Windows.Forms.TextBox();
            this.txtMySQLSecondaryService = new System.Windows.Forms.TextBox();
            this.txtMySQLMainService = new System.Windows.Forms.TextBox();
            this.tpPostgreSQL = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPostgreSQLExtraService = new System.Windows.Forms.TextBox();
            this.txtPostgreSQLSecondaryService = new System.Windows.Forms.TextBox();
            this.txtPostgreSQLMainService = new System.Windows.Forms.TextBox();
            this.tpMariaDB = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMariaDBExtraService = new System.Windows.Forms.TextBox();
            this.txtMariaDBSecondaryService = new System.Windows.Forms.TextBox();
            this.txtMariaDBMainService = new System.Windows.Forms.TextBox();
            this.tpMongoDB = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMongoDBExtraService = new System.Windows.Forms.TextBox();
            this.txtMongoDBSecondaryService = new System.Windows.Forms.TextBox();
            this.txtMongoDBMainService = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnEnableEdit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabConfigs.SuspendLayout();
            this.tpSQLServer.SuspendLayout();
            this.tpMySQL.SuspendLayout();
            this.tpPostgreSQL.SuspendLayout();
            this.tpMariaDB.SuspendLayout();
            this.tpMongoDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabConfigs
            // 
            this.tabConfigs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabConfigs.Controls.Add(this.tpSQLServer);
            this.tabConfigs.Controls.Add(this.tpMySQL);
            this.tabConfigs.Controls.Add(this.tpPostgreSQL);
            this.tabConfigs.Controls.Add(this.tpMariaDB);
            this.tabConfigs.Controls.Add(this.tpMongoDB);
            this.tabConfigs.Location = new System.Drawing.Point(12, 12);
            this.tabConfigs.Name = "tabConfigs";
            this.tabConfigs.SelectedIndex = 0;
            this.tabConfigs.Size = new System.Drawing.Size(450, 257);
            this.tabConfigs.TabIndex = 0;
            // 
            // tpSQLServer
            // 
            this.tpSQLServer.Controls.Add(this.label8);
            this.tpSQLServer.Controls.Add(this.label7);
            this.tpSQLServer.Controls.Add(this.label6);
            this.tpSQLServer.Controls.Add(this.txtSQLServerExtraService);
            this.tpSQLServer.Controls.Add(this.txtSQLServerSecondaryService);
            this.tpSQLServer.Controls.Add(this.txtSQLServerMainService);
            this.tpSQLServer.Location = new System.Drawing.Point(4, 24);
            this.tpSQLServer.Name = "tpSQLServer";
            this.tpSQLServer.Padding = new System.Windows.Forms.Padding(3);
            this.tpSQLServer.Size = new System.Drawing.Size(442, 229);
            this.tpSQLServer.TabIndex = 0;
            this.tpSQLServer.Text = "SQL Server";
            this.tpSQLServer.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(3, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "SERVIÇO EXTRA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(6, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "SERVIÇO SECUNDÁRIO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "SERVIÇO PRINCIPAL";
            // 
            // txtSQLServerExtraService
            // 
            this.txtSQLServerExtraService.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSQLServerExtraService.Location = new System.Drawing.Point(6, 161);
            this.txtSQLServerExtraService.Name = "txtSQLServerExtraService";
            this.txtSQLServerExtraService.ReadOnly = true;
            this.txtSQLServerExtraService.Size = new System.Drawing.Size(430, 29);
            this.txtSQLServerExtraService.TabIndex = 2;
            this.txtSQLServerExtraService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSQLServerSecondaryService
            // 
            this.txtSQLServerSecondaryService.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSQLServerSecondaryService.Location = new System.Drawing.Point(6, 101);
            this.txtSQLServerSecondaryService.Name = "txtSQLServerSecondaryService";
            this.txtSQLServerSecondaryService.ReadOnly = true;
            this.txtSQLServerSecondaryService.Size = new System.Drawing.Size(430, 29);
            this.txtSQLServerSecondaryService.TabIndex = 2;
            this.txtSQLServerSecondaryService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSQLServerMainService
            // 
            this.txtSQLServerMainService.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSQLServerMainService.Location = new System.Drawing.Point(6, 41);
            this.txtSQLServerMainService.Name = "txtSQLServerMainService";
            this.txtSQLServerMainService.ReadOnly = true;
            this.txtSQLServerMainService.Size = new System.Drawing.Size(430, 29);
            this.txtSQLServerMainService.TabIndex = 2;
            this.txtSQLServerMainService.Text = "MSSQL$SQLEXPRESS";
            this.txtSQLServerMainService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tpMySQL
            // 
            this.tpMySQL.Controls.Add(this.label1);
            this.tpMySQL.Controls.Add(this.label9);
            this.tpMySQL.Controls.Add(this.label10);
            this.tpMySQL.Controls.Add(this.txtMySQLExtraService);
            this.tpMySQL.Controls.Add(this.txtMySQLSecondaryService);
            this.tpMySQL.Controls.Add(this.txtMySQLMainService);
            this.tpMySQL.Location = new System.Drawing.Point(4, 24);
            this.tpMySQL.Name = "tpMySQL";
            this.tpMySQL.Padding = new System.Windows.Forms.Padding(3);
            this.tpMySQL.Size = new System.Drawing.Size(442, 229);
            this.tpMySQL.TabIndex = 1;
            this.tpMySQL.Text = "MySQL";
            this.tpMySQL.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Serviço extra";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(107, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Serviço secundário";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(107, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Serviço principal";
            // 
            // txtMySQLExtraService
            // 
            this.txtMySQLExtraService.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMySQLExtraService.Location = new System.Drawing.Point(6, 138);
            this.txtMySQLExtraService.Name = "txtMySQLExtraService";
            this.txtMySQLExtraService.ReadOnly = true;
            this.txtMySQLExtraService.Size = new System.Drawing.Size(430, 29);
            this.txtMySQLExtraService.TabIndex = 5;
            this.txtMySQLExtraService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMySQLSecondaryService
            // 
            this.txtMySQLSecondaryService.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMySQLSecondaryService.Location = new System.Drawing.Point(6, 90);
            this.txtMySQLSecondaryService.Name = "txtMySQLSecondaryService";
            this.txtMySQLSecondaryService.ReadOnly = true;
            this.txtMySQLSecondaryService.Size = new System.Drawing.Size(430, 29);
            this.txtMySQLSecondaryService.TabIndex = 6;
            this.txtMySQLSecondaryService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMySQLMainService
            // 
            this.txtMySQLMainService.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMySQLMainService.Location = new System.Drawing.Point(6, 42);
            this.txtMySQLMainService.Name = "txtMySQLMainService";
            this.txtMySQLMainService.ReadOnly = true;
            this.txtMySQLMainService.Size = new System.Drawing.Size(430, 29);
            this.txtMySQLMainService.TabIndex = 2;
            this.txtMySQLMainService.Text = "MySQL80";
            this.txtMySQLMainService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tpPostgreSQL
            // 
            this.tpPostgreSQL.Controls.Add(this.label2);
            this.tpPostgreSQL.Controls.Add(this.label3);
            this.tpPostgreSQL.Controls.Add(this.label11);
            this.tpPostgreSQL.Controls.Add(this.txtPostgreSQLExtraService);
            this.tpPostgreSQL.Controls.Add(this.txtPostgreSQLSecondaryService);
            this.tpPostgreSQL.Controls.Add(this.txtPostgreSQLMainService);
            this.tpPostgreSQL.Location = new System.Drawing.Point(4, 24);
            this.tpPostgreSQL.Name = "tpPostgreSQL";
            this.tpPostgreSQL.Size = new System.Drawing.Size(442, 229);
            this.tpPostgreSQL.TabIndex = 2;
            this.tpPostgreSQL.Text = "PostgreSQL";
            this.tpPostgreSQL.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Serviço extra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Serviço secundário";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(107, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Serviço principal";
            // 
            // txtPostgreSQLExtraService
            // 
            this.txtPostgreSQLExtraService.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPostgreSQLExtraService.Location = new System.Drawing.Point(3, 138);
            this.txtPostgreSQLExtraService.Name = "txtPostgreSQLExtraService";
            this.txtPostgreSQLExtraService.ReadOnly = true;
            this.txtPostgreSQLExtraService.Size = new System.Drawing.Size(436, 29);
            this.txtPostgreSQLExtraService.TabIndex = 12;
            this.txtPostgreSQLExtraService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPostgreSQLSecondaryService
            // 
            this.txtPostgreSQLSecondaryService.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPostgreSQLSecondaryService.Location = new System.Drawing.Point(3, 90);
            this.txtPostgreSQLSecondaryService.Name = "txtPostgreSQLSecondaryService";
            this.txtPostgreSQLSecondaryService.ReadOnly = true;
            this.txtPostgreSQLSecondaryService.Size = new System.Drawing.Size(436, 29);
            this.txtPostgreSQLSecondaryService.TabIndex = 13;
            this.txtPostgreSQLSecondaryService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPostgreSQLMainService
            // 
            this.txtPostgreSQLMainService.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPostgreSQLMainService.Location = new System.Drawing.Point(3, 42);
            this.txtPostgreSQLMainService.Name = "txtPostgreSQLMainService";
            this.txtPostgreSQLMainService.ReadOnly = true;
            this.txtPostgreSQLMainService.Size = new System.Drawing.Size(436, 29);
            this.txtPostgreSQLMainService.TabIndex = 2;
            this.txtPostgreSQLMainService.Text = "postgresql-x64-15";
            this.txtPostgreSQLMainService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tpMariaDB
            // 
            this.tpMariaDB.Controls.Add(this.label4);
            this.tpMariaDB.Controls.Add(this.label12);
            this.tpMariaDB.Controls.Add(this.label13);
            this.tpMariaDB.Controls.Add(this.txtMariaDBExtraService);
            this.tpMariaDB.Controls.Add(this.txtMariaDBSecondaryService);
            this.tpMariaDB.Controls.Add(this.txtMariaDBMainService);
            this.tpMariaDB.Location = new System.Drawing.Point(4, 24);
            this.tpMariaDB.Name = "tpMariaDB";
            this.tpMariaDB.Size = new System.Drawing.Size(442, 229);
            this.tpMariaDB.TabIndex = 3;
            this.tpMariaDB.Text = "MariaDB";
            this.tpMariaDB.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Serviço extra";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(107, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 15);
            this.label12.TabIndex = 16;
            this.label12.Text = "Serviço secundário";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(107, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 15);
            this.label13.TabIndex = 17;
            this.label13.Text = "Serviço principal";
            // 
            // txtMariaDBExtraService
            // 
            this.txtMariaDBExtraService.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMariaDBExtraService.Location = new System.Drawing.Point(3, 138);
            this.txtMariaDBExtraService.Name = "txtMariaDBExtraService";
            this.txtMariaDBExtraService.ReadOnly = true;
            this.txtMariaDBExtraService.Size = new System.Drawing.Size(436, 29);
            this.txtMariaDBExtraService.TabIndex = 12;
            this.txtMariaDBExtraService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMariaDBSecondaryService
            // 
            this.txtMariaDBSecondaryService.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMariaDBSecondaryService.Location = new System.Drawing.Point(3, 90);
            this.txtMariaDBSecondaryService.Name = "txtMariaDBSecondaryService";
            this.txtMariaDBSecondaryService.ReadOnly = true;
            this.txtMariaDBSecondaryService.Size = new System.Drawing.Size(436, 29);
            this.txtMariaDBSecondaryService.TabIndex = 13;
            this.txtMariaDBSecondaryService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMariaDBMainService
            // 
            this.txtMariaDBMainService.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMariaDBMainService.Location = new System.Drawing.Point(3, 41);
            this.txtMariaDBMainService.Name = "txtMariaDBMainService";
            this.txtMariaDBMainService.ReadOnly = true;
            this.txtMariaDBMainService.Size = new System.Drawing.Size(436, 29);
            this.txtMariaDBMainService.TabIndex = 2;
            this.txtMariaDBMainService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tpMongoDB
            // 
            this.tpMongoDB.Controls.Add(this.label5);
            this.tpMongoDB.Controls.Add(this.label14);
            this.tpMongoDB.Controls.Add(this.label15);
            this.tpMongoDB.Controls.Add(this.txtMongoDBExtraService);
            this.tpMongoDB.Controls.Add(this.txtMongoDBSecondaryService);
            this.tpMongoDB.Controls.Add(this.txtMongoDBMainService);
            this.tpMongoDB.Location = new System.Drawing.Point(4, 24);
            this.tpMongoDB.Name = "tpMongoDB";
            this.tpMongoDB.Size = new System.Drawing.Size(442, 229);
            this.tpMongoDB.TabIndex = 4;
            this.tpMongoDB.Text = "MongoDB";
            this.tpMongoDB.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Serviço extra";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(107, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 15);
            this.label14.TabIndex = 16;
            this.label14.Text = "Serviço secundário";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(107, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 15);
            this.label15.TabIndex = 17;
            this.label15.Text = "Serviço principal";
            // 
            // txtMongoDBExtraService
            // 
            this.txtMongoDBExtraService.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMongoDBExtraService.Location = new System.Drawing.Point(3, 138);
            this.txtMongoDBExtraService.Name = "txtMongoDBExtraService";
            this.txtMongoDBExtraService.ReadOnly = true;
            this.txtMongoDBExtraService.Size = new System.Drawing.Size(436, 29);
            this.txtMongoDBExtraService.TabIndex = 12;
            this.txtMongoDBExtraService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMongoDBSecondaryService
            // 
            this.txtMongoDBSecondaryService.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMongoDBSecondaryService.Location = new System.Drawing.Point(3, 90);
            this.txtMongoDBSecondaryService.Name = "txtMongoDBSecondaryService";
            this.txtMongoDBSecondaryService.ReadOnly = true;
            this.txtMongoDBSecondaryService.Size = new System.Drawing.Size(436, 29);
            this.txtMongoDBSecondaryService.TabIndex = 13;
            this.txtMongoDBSecondaryService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMongoDBMainService
            // 
            this.txtMongoDBMainService.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMongoDBMainService.Location = new System.Drawing.Point(3, 41);
            this.txtMongoDBMainService.Name = "txtMongoDBMainService";
            this.txtMongoDBMainService.ReadOnly = true;
            this.txtMongoDBMainService.Size = new System.Drawing.Size(436, 29);
            this.txtMongoDBMainService.TabIndex = 2;
            this.txtMongoDBMainService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirm.Location = new System.Drawing.Point(16, 271);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(442, 38);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirmar configurações";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnEnableEdit
            // 
            this.btnEnableEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEnableEdit.Image")));
            this.btnEnableEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnableEdit.Location = new System.Drawing.Point(16, 271);
            this.btnEnableEdit.Name = "btnEnableEdit";
            this.btnEnableEdit.Size = new System.Drawing.Size(442, 38);
            this.btnEnableEdit.TabIndex = 18;
            this.btnEnableEdit.Text = "Editar parâmetros";
            this.btnEnableEdit.UseVisualStyleBackColor = true;
            this.btnEnableEdit.Click += new System.EventHandler(this.btnEnableEdit_Click);
            // 
            // btnClose
            // 
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(13, 349);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(449, 33);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Fechar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmConfigs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(474, 394);
            this.ControlBox = false;
            this.Controls.Add(this.btnEnableEdit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tabConfigs);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmConfigs";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações dos serviços";
            this.TopMost = true;
            this.tabConfigs.ResumeLayout(false);
            this.tpSQLServer.ResumeLayout(false);
            this.tpSQLServer.PerformLayout();
            this.tpMySQL.ResumeLayout(false);
            this.tpMySQL.PerformLayout();
            this.tpPostgreSQL.ResumeLayout(false);
            this.tpPostgreSQL.PerformLayout();
            this.tpMariaDB.ResumeLayout(false);
            this.tpMariaDB.PerformLayout();
            this.tpMongoDB.ResumeLayout(false);
            this.tpMongoDB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConfirm;
        public System.Windows.Forms.TextBox txtPostgreSQLMainService;
        public System.Windows.Forms.TextBox txtMySQLMainService;
        public System.Windows.Forms.TextBox txtSQLServerMainService;
        public System.Windows.Forms.TextBox txtMariaDBMainService;
        public System.Windows.Forms.TextBox txtMongoDBMainService;
        public System.Windows.Forms.TabControl tabConfigs;
        public System.Windows.Forms.TabPage tpSQLServer;
        public System.Windows.Forms.TabPage tpMySQL;
        public System.Windows.Forms.TabPage tpPostgreSQL;
        public System.Windows.Forms.TabPage tpMariaDB;
        public System.Windows.Forms.TabPage tpMongoDB;
        public System.Windows.Forms.TextBox txtSQLServerExtraService;
        public System.Windows.Forms.TextBox txtSQLServerSecondaryService;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtMySQLExtraService;
        public System.Windows.Forms.TextBox txtMySQLSecondaryService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtPostgreSQLExtraService;
        public System.Windows.Forms.TextBox txtPostgreSQLSecondaryService;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtMariaDBExtraService;
        public System.Windows.Forms.TextBox txtMariaDBSecondaryService;
        private System.Windows.Forms.Button btnEnableEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox txtMongoDBExtraService;
        public System.Windows.Forms.TextBox txtMongoDBSecondaryService;
        private System.Windows.Forms.Button btnClose;
    }
}