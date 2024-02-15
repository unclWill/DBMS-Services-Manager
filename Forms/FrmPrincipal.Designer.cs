﻿namespace MachineStop
{
    partial class FrmPrincipal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            panel2 = new System.Windows.Forms.Panel();
            btnRestartMySQL = new System.Windows.Forms.Button();
            btnStopMySQL = new System.Windows.Forms.Button();
            txtMySQLServiceStatus = new System.Windows.Forms.TextBox();
            panel5 = new System.Windows.Forms.Panel();
            btnRestartMongoDB = new System.Windows.Forms.Button();
            btnStopMongoDB = new System.Windows.Forms.Button();
            txtMongoDBServiceStatus = new System.Windows.Forms.TextBox();
            panel4 = new System.Windows.Forms.Panel();
            btnRestartMariaDB = new System.Windows.Forms.Button();
            btnStopMariaDB = new System.Windows.Forms.Button();
            txtMariaDBServiceStatus = new System.Windows.Forms.TextBox();
            panel3 = new System.Windows.Forms.Panel();
            btnRestartPostgreSQL = new System.Windows.Forms.Button();
            btnStopPostgreSQL = new System.Windows.Forms.Button();
            txtPostgreSQLServiceStatus = new System.Windows.Forms.TextBox();
            txtSQLServerServiceStatus = new System.Windows.Forms.TextBox();
            pbMongoDBServiceStatus = new System.Windows.Forms.PictureBox();
            pbMariaDBServiceStatus = new System.Windows.Forms.PictureBox();
            pbPostgreSQLServiceStatus = new System.Windows.Forms.PictureBox();
            pbMySQLServiceStatus = new System.Windows.Forms.PictureBox();
            pbSQLServerServiceStatus = new System.Windows.Forms.PictureBox();
            pnlMongoDB = new System.Windows.Forms.Panel();
            pbMongoDBLogo = new System.Windows.Forms.PictureBox();
            pnlMariaDB = new System.Windows.Forms.Panel();
            pbMariaDBLogo = new System.Windows.Forms.PictureBox();
            pnlPostgreSQL = new System.Windows.Forms.Panel();
            pbPostgreSQLLogo = new System.Windows.Forms.PictureBox();
            pnlMySQL = new System.Windows.Forms.Panel();
            pbMySQLLogo = new System.Windows.Forms.PictureBox();
            pnlSQLServer = new System.Windows.Forms.Panel();
            pbSQLServerLogo = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            btnRestartSQLServer = new System.Windows.Forms.Button();
            btnStopSQLServer = new System.Windows.Forms.Button();
            pnlHeader = new System.Windows.Forms.Panel();
            lblApplicationName = new System.Windows.Forms.Label();
            btnAbout = new System.Windows.Forms.Button();
            pbDeveloperLogo = new System.Windows.Forms.PictureBox();
            btnMinimize = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            tmrServiceStatusVerifier = new System.Windows.Forms.Timer(components);
            btnStopAllServices = new System.Windows.Forms.Button();
            btnRestartAllServices = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            pnlServicesMainController = new System.Windows.Forms.Panel();
            pnlServicesControllerBorder = new System.Windows.Forms.Panel();
            btnSettings = new System.Windows.Forms.Button();
            lblQuickCommands = new System.Windows.Forms.Label();
            lblManageServices = new System.Windows.Forms.Label();
            pnlServiceStatus = new System.Windows.Forms.Panel();
            lblServiceStatus = new System.Windows.Forms.Label();
            pnlFooter = new System.Windows.Forms.Panel();
            pnlServiceLogo = new System.Windows.Forms.Panel();
            lblServices = new System.Windows.Forms.Label();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMongoDBServiceStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMariaDBServiceStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPostgreSQLServiceStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMySQLServiceStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSQLServerServiceStatus).BeginInit();
            pnlMongoDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMongoDBLogo).BeginInit();
            pnlMariaDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMariaDBLogo).BeginInit();
            pnlPostgreSQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPostgreSQLLogo).BeginInit();
            pnlMySQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMySQLLogo).BeginInit();
            pnlSQLServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSQLServerLogo).BeginInit();
            panel1.SuspendLayout();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDeveloperLogo).BeginInit();
            pnlServicesMainController.SuspendLayout();
            pnlServicesControllerBorder.SuspendLayout();
            pnlServiceStatus.SuspendLayout();
            pnlServiceLogo.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(btnRestartMySQL);
            panel2.Controls.Add(btnStopMySQL);
            panel2.Location = new System.Drawing.Point(146, 15);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(330, 37);
            panel2.TabIndex = 4;
            // 
            // btnRestartMySQL
            // 
            btnRestartMySQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRestartMySQL.Image = DBMS_Services_Manager.Properties.Resources.Play;
            btnRestartMySQL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnRestartMySQL.Location = new System.Drawing.Point(164, -1);
            btnRestartMySQL.Name = "btnRestartMySQL";
            btnRestartMySQL.Size = new System.Drawing.Size(165, 37);
            btnRestartMySQL.TabIndex = 0;
            btnRestartMySQL.Text = "Reiniciar serviços";
            btnRestartMySQL.UseVisualStyleBackColor = true;
            btnRestartMySQL.Click += btnRestartMySQL_Click;
            // 
            // btnStopMySQL
            // 
            btnStopMySQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStopMySQL.Image = DBMS_Services_Manager.Properties.Resources.Abort;
            btnStopMySQL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnStopMySQL.Location = new System.Drawing.Point(-1, -1);
            btnStopMySQL.Name = "btnStopMySQL";
            btnStopMySQL.Size = new System.Drawing.Size(166, 37);
            btnStopMySQL.TabIndex = 0;
            btnStopMySQL.Text = "Parar serviços";
            btnStopMySQL.UseVisualStyleBackColor = true;
            btnStopMySQL.Click += btnStopMySQL_Click;
            // 
            // txtMySQLServiceStatus
            // 
            txtMySQLServiceStatus.BackColor = System.Drawing.Color.White;
            txtMySQLServiceStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtMySQLServiceStatus.Enabled = false;
            txtMySQLServiceStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtMySQLServiceStatus.Location = new System.Drawing.Point(507, 43);
            txtMySQLServiceStatus.Name = "txtMySQLServiceStatus";
            txtMySQLServiceStatus.ReadOnly = true;
            txtMySQLServiceStatus.Size = new System.Drawing.Size(101, 16);
            txtMySQLServiceStatus.TabIndex = 5;
            txtMySQLServiceStatus.TabStop = false;
            txtMySQLServiceStatus.Text = "Status";
            txtMySQLServiceStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel5
            // 
            panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel5.Controls.Add(btnRestartMongoDB);
            panel5.Controls.Add(btnStopMongoDB);
            panel5.Location = new System.Drawing.Point(146, 15);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(330, 37);
            panel5.TabIndex = 4;
            // 
            // btnRestartMongoDB
            // 
            btnRestartMongoDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRestartMongoDB.Image = DBMS_Services_Manager.Properties.Resources.Play;
            btnRestartMongoDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnRestartMongoDB.Location = new System.Drawing.Point(164, -1);
            btnRestartMongoDB.Name = "btnRestartMongoDB";
            btnRestartMongoDB.Size = new System.Drawing.Size(165, 37);
            btnRestartMongoDB.TabIndex = 0;
            btnRestartMongoDB.Text = "Reiniciar serviços";
            btnRestartMongoDB.UseVisualStyleBackColor = true;
            btnRestartMongoDB.Click += btnRestartMongoDB_Click;
            // 
            // btnStopMongoDB
            // 
            btnStopMongoDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStopMongoDB.Image = DBMS_Services_Manager.Properties.Resources.Abort;
            btnStopMongoDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnStopMongoDB.Location = new System.Drawing.Point(-1, -1);
            btnStopMongoDB.Name = "btnStopMongoDB";
            btnStopMongoDB.Size = new System.Drawing.Size(166, 37);
            btnStopMongoDB.TabIndex = 0;
            btnStopMongoDB.Text = "Parar serviços";
            btnStopMongoDB.UseVisualStyleBackColor = true;
            btnStopMongoDB.Click += btnStopMongoDB_Click;
            // 
            // txtMongoDBServiceStatus
            // 
            txtMongoDBServiceStatus.BackColor = System.Drawing.Color.White;
            txtMongoDBServiceStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtMongoDBServiceStatus.Enabled = false;
            txtMongoDBServiceStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtMongoDBServiceStatus.Location = new System.Drawing.Point(507, 43);
            txtMongoDBServiceStatus.Name = "txtMongoDBServiceStatus";
            txtMongoDBServiceStatus.ReadOnly = true;
            txtMongoDBServiceStatus.Size = new System.Drawing.Size(101, 16);
            txtMongoDBServiceStatus.TabIndex = 5;
            txtMongoDBServiceStatus.TabStop = false;
            txtMongoDBServiceStatus.Text = "Status";
            txtMongoDBServiceStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel4.Controls.Add(btnRestartMariaDB);
            panel4.Controls.Add(btnStopMariaDB);
            panel4.Location = new System.Drawing.Point(146, 15);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(330, 37);
            panel4.TabIndex = 4;
            // 
            // btnRestartMariaDB
            // 
            btnRestartMariaDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRestartMariaDB.Image = DBMS_Services_Manager.Properties.Resources.Play;
            btnRestartMariaDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnRestartMariaDB.Location = new System.Drawing.Point(164, -1);
            btnRestartMariaDB.Name = "btnRestartMariaDB";
            btnRestartMariaDB.Size = new System.Drawing.Size(165, 37);
            btnRestartMariaDB.TabIndex = 0;
            btnRestartMariaDB.Text = "Reiniciar serviços";
            btnRestartMariaDB.UseVisualStyleBackColor = true;
            btnRestartMariaDB.Click += btnRestartMariaDB_Click;
            // 
            // btnStopMariaDB
            // 
            btnStopMariaDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStopMariaDB.Image = DBMS_Services_Manager.Properties.Resources.Abort;
            btnStopMariaDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnStopMariaDB.Location = new System.Drawing.Point(-1, -1);
            btnStopMariaDB.Name = "btnStopMariaDB";
            btnStopMariaDB.Size = new System.Drawing.Size(166, 37);
            btnStopMariaDB.TabIndex = 0;
            btnStopMariaDB.Text = "Parar serviços";
            btnStopMariaDB.UseVisualStyleBackColor = true;
            btnStopMariaDB.Click += btnStopMariaDB_Click;
            // 
            // txtMariaDBServiceStatus
            // 
            txtMariaDBServiceStatus.BackColor = System.Drawing.Color.White;
            txtMariaDBServiceStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtMariaDBServiceStatus.Enabled = false;
            txtMariaDBServiceStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtMariaDBServiceStatus.Location = new System.Drawing.Point(507, 43);
            txtMariaDBServiceStatus.Name = "txtMariaDBServiceStatus";
            txtMariaDBServiceStatus.ReadOnly = true;
            txtMariaDBServiceStatus.Size = new System.Drawing.Size(101, 16);
            txtMariaDBServiceStatus.TabIndex = 5;
            txtMariaDBServiceStatus.TabStop = false;
            txtMariaDBServiceStatus.Text = "Status";
            txtMariaDBServiceStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel3.Controls.Add(btnRestartPostgreSQL);
            panel3.Controls.Add(btnStopPostgreSQL);
            panel3.Location = new System.Drawing.Point(146, 15);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(330, 37);
            panel3.TabIndex = 4;
            // 
            // btnRestartPostgreSQL
            // 
            btnRestartPostgreSQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRestartPostgreSQL.Image = DBMS_Services_Manager.Properties.Resources.Play;
            btnRestartPostgreSQL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnRestartPostgreSQL.Location = new System.Drawing.Point(164, -1);
            btnRestartPostgreSQL.Name = "btnRestartPostgreSQL";
            btnRestartPostgreSQL.Size = new System.Drawing.Size(165, 37);
            btnRestartPostgreSQL.TabIndex = 0;
            btnRestartPostgreSQL.Text = "Reiniciar serviços";
            btnRestartPostgreSQL.UseVisualStyleBackColor = true;
            btnRestartPostgreSQL.Click += btnRestartPostgreSQL_Click;
            // 
            // btnStopPostgreSQL
            // 
            btnStopPostgreSQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStopPostgreSQL.Image = DBMS_Services_Manager.Properties.Resources.Abort;
            btnStopPostgreSQL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnStopPostgreSQL.Location = new System.Drawing.Point(-1, -1);
            btnStopPostgreSQL.Name = "btnStopPostgreSQL";
            btnStopPostgreSQL.Size = new System.Drawing.Size(166, 37);
            btnStopPostgreSQL.TabIndex = 0;
            btnStopPostgreSQL.Text = "Parar serviços";
            btnStopPostgreSQL.UseVisualStyleBackColor = true;
            btnStopPostgreSQL.Click += btnStopPostgreSQL_Click;
            // 
            // txtPostgreSQLServiceStatus
            // 
            txtPostgreSQLServiceStatus.BackColor = System.Drawing.Color.White;
            txtPostgreSQLServiceStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtPostgreSQLServiceStatus.Enabled = false;
            txtPostgreSQLServiceStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtPostgreSQLServiceStatus.Location = new System.Drawing.Point(507, 43);
            txtPostgreSQLServiceStatus.Name = "txtPostgreSQLServiceStatus";
            txtPostgreSQLServiceStatus.ReadOnly = true;
            txtPostgreSQLServiceStatus.Size = new System.Drawing.Size(101, 16);
            txtPostgreSQLServiceStatus.TabIndex = 4;
            txtPostgreSQLServiceStatus.TabStop = false;
            txtPostgreSQLServiceStatus.Text = "Status";
            txtPostgreSQLServiceStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSQLServerServiceStatus
            // 
            txtSQLServerServiceStatus.BackColor = System.Drawing.Color.White;
            txtSQLServerServiceStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtSQLServerServiceStatus.Enabled = false;
            txtSQLServerServiceStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtSQLServerServiceStatus.Location = new System.Drawing.Point(507, 43);
            txtSQLServerServiceStatus.Name = "txtSQLServerServiceStatus";
            txtSQLServerServiceStatus.ReadOnly = true;
            txtSQLServerServiceStatus.Size = new System.Drawing.Size(101, 16);
            txtSQLServerServiceStatus.TabIndex = 5;
            txtSQLServerServiceStatus.TabStop = false;
            txtSQLServerServiceStatus.Text = "Status";
            txtSQLServerServiceStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbMongoDBServiceStatus
            // 
            pbMongoDBServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.Danger;
            pbMongoDBServiceStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            pbMongoDBServiceStatus.Location = new System.Drawing.Point(531, 7);
            pbMongoDBServiceStatus.Name = "pbMongoDBServiceStatus";
            pbMongoDBServiceStatus.Size = new System.Drawing.Size(54, 32);
            pbMongoDBServiceStatus.TabIndex = 3;
            pbMongoDBServiceStatus.TabStop = false;
            // 
            // pbMariaDBServiceStatus
            // 
            pbMariaDBServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.Danger;
            pbMariaDBServiceStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            pbMariaDBServiceStatus.Location = new System.Drawing.Point(531, 7);
            pbMariaDBServiceStatus.Name = "pbMariaDBServiceStatus";
            pbMariaDBServiceStatus.Size = new System.Drawing.Size(54, 32);
            pbMariaDBServiceStatus.TabIndex = 3;
            pbMariaDBServiceStatus.TabStop = false;
            // 
            // pbPostgreSQLServiceStatus
            // 
            pbPostgreSQLServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.Danger;
            pbPostgreSQLServiceStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            pbPostgreSQLServiceStatus.Location = new System.Drawing.Point(531, 7);
            pbPostgreSQLServiceStatus.Name = "pbPostgreSQLServiceStatus";
            pbPostgreSQLServiceStatus.Size = new System.Drawing.Size(54, 32);
            pbPostgreSQLServiceStatus.TabIndex = 3;
            pbPostgreSQLServiceStatus.TabStop = false;
            // 
            // pbMySQLServiceStatus
            // 
            pbMySQLServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.Danger;
            pbMySQLServiceStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            pbMySQLServiceStatus.Location = new System.Drawing.Point(531, 7);
            pbMySQLServiceStatus.Name = "pbMySQLServiceStatus";
            pbMySQLServiceStatus.Size = new System.Drawing.Size(54, 32);
            pbMySQLServiceStatus.TabIndex = 3;
            pbMySQLServiceStatus.TabStop = false;
            // 
            // pbSQLServerServiceStatus
            // 
            pbSQLServerServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.Danger;
            pbSQLServerServiceStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            pbSQLServerServiceStatus.Location = new System.Drawing.Point(531, 7);
            pbSQLServerServiceStatus.Name = "pbSQLServerServiceStatus";
            pbSQLServerServiceStatus.Size = new System.Drawing.Size(54, 32);
            pbSQLServerServiceStatus.TabIndex = 3;
            pbSQLServerServiceStatus.TabStop = false;
            // 
            // pnlMongoDB
            // 
            pnlMongoDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            pnlMongoDB.BackColor = System.Drawing.Color.White;
            pnlMongoDB.Controls.Add(txtMongoDBServiceStatus);
            pnlMongoDB.Controls.Add(pbMongoDBServiceStatus);
            pnlMongoDB.Controls.Add(panel5);
            pnlMongoDB.Controls.Add(pbMongoDBLogo);
            pnlMongoDB.Location = new System.Drawing.Point(12, 519);
            pnlMongoDB.Name = "pnlMongoDB";
            pnlMongoDB.Size = new System.Drawing.Size(623, 71);
            pnlMongoDB.TabIndex = 8;
            // 
            // pbMongoDBLogo
            // 
            pbMongoDBLogo.BackColor = System.Drawing.SystemColors.Window;
            pbMongoDBLogo.BackgroundImage = DBMS_Services_Manager.Properties.Resources._2560px_MongoDB_Logo_svg;
            pbMongoDBLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pbMongoDBLogo.Location = new System.Drawing.Point(-1, -1);
            pbMongoDBLogo.Name = "pbMongoDBLogo";
            pbMongoDBLogo.Size = new System.Drawing.Size(131, 73);
            pbMongoDBLogo.TabIndex = 6;
            pbMongoDBLogo.TabStop = false;
            // 
            // pnlMariaDB
            // 
            pnlMariaDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            pnlMariaDB.BackColor = System.Drawing.Color.White;
            pnlMariaDB.Controls.Add(txtMariaDBServiceStatus);
            pnlMariaDB.Controls.Add(pbMariaDBLogo);
            pnlMariaDB.Controls.Add(pbMariaDBServiceStatus);
            pnlMariaDB.Controls.Add(panel4);
            pnlMariaDB.Location = new System.Drawing.Point(12, 432);
            pnlMariaDB.Name = "pnlMariaDB";
            pnlMariaDB.Size = new System.Drawing.Size(623, 71);
            pnlMariaDB.TabIndex = 8;
            // 
            // pbMariaDBLogo
            // 
            pbMariaDBLogo.BackColor = System.Drawing.SystemColors.Window;
            pbMariaDBLogo.BackgroundImage = DBMS_Services_Manager.Properties.Resources.Mariadb_seal_browntext_svg;
            pbMariaDBLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pbMariaDBLogo.Location = new System.Drawing.Point(-1, -1);
            pbMariaDBLogo.Name = "pbMariaDBLogo";
            pbMariaDBLogo.Size = new System.Drawing.Size(131, 73);
            pbMariaDBLogo.TabIndex = 6;
            pbMariaDBLogo.TabStop = false;
            // 
            // pnlPostgreSQL
            // 
            pnlPostgreSQL.Anchor = System.Windows.Forms.AnchorStyles.None;
            pnlPostgreSQL.BackColor = System.Drawing.Color.White;
            pnlPostgreSQL.Controls.Add(txtPostgreSQLServiceStatus);
            pnlPostgreSQL.Controls.Add(pbPostgreSQLLogo);
            pnlPostgreSQL.Controls.Add(panel3);
            pnlPostgreSQL.Controls.Add(pbPostgreSQLServiceStatus);
            pnlPostgreSQL.Location = new System.Drawing.Point(12, 344);
            pnlPostgreSQL.Name = "pnlPostgreSQL";
            pnlPostgreSQL.Size = new System.Drawing.Size(623, 71);
            pnlPostgreSQL.TabIndex = 8;
            // 
            // pbPostgreSQLLogo
            // 
            pbPostgreSQLLogo.BackColor = System.Drawing.SystemColors.Window;
            pbPostgreSQLLogo.BackgroundImage = DBMS_Services_Manager.Properties.Resources._242_2423721_logo_postgresql;
            pbPostgreSQLLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pbPostgreSQLLogo.Location = new System.Drawing.Point(-1, -1);
            pbPostgreSQLLogo.Name = "pbPostgreSQLLogo";
            pbPostgreSQLLogo.Size = new System.Drawing.Size(131, 73);
            pbPostgreSQLLogo.TabIndex = 6;
            pbPostgreSQLLogo.TabStop = false;
            // 
            // pnlMySQL
            // 
            pnlMySQL.Anchor = System.Windows.Forms.AnchorStyles.None;
            pnlMySQL.BackColor = System.Drawing.Color.White;
            pnlMySQL.Controls.Add(txtMySQLServiceStatus);
            pnlMySQL.Controls.Add(panel2);
            pnlMySQL.Controls.Add(pbMySQLLogo);
            pnlMySQL.Controls.Add(pbMySQLServiceStatus);
            pnlMySQL.Location = new System.Drawing.Point(12, 256);
            pnlMySQL.Name = "pnlMySQL";
            pnlMySQL.Size = new System.Drawing.Size(623, 71);
            pnlMySQL.TabIndex = 8;
            // 
            // pbMySQLLogo
            // 
            pbMySQLLogo.BackColor = System.Drawing.SystemColors.Window;
            pbMySQLLogo.BackgroundImage = DBMS_Services_Manager.Properties.Resources.Mysql_logo;
            pbMySQLLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pbMySQLLogo.Location = new System.Drawing.Point(-1, -2);
            pbMySQLLogo.Name = "pbMySQLLogo";
            pbMySQLLogo.Size = new System.Drawing.Size(131, 74);
            pbMySQLLogo.TabIndex = 6;
            pbMySQLLogo.TabStop = false;
            // 
            // pnlSQLServer
            // 
            pnlSQLServer.Anchor = System.Windows.Forms.AnchorStyles.None;
            pnlSQLServer.BackColor = System.Drawing.Color.White;
            pnlSQLServer.Controls.Add(pbSQLServerLogo);
            pnlSQLServer.Controls.Add(pbSQLServerServiceStatus);
            pnlSQLServer.Controls.Add(txtSQLServerServiceStatus);
            pnlSQLServer.Controls.Add(panel1);
            pnlSQLServer.Location = new System.Drawing.Point(12, 169);
            pnlSQLServer.Name = "pnlSQLServer";
            pnlSQLServer.Size = new System.Drawing.Size(623, 71);
            pnlSQLServer.TabIndex = 8;
            // 
            // pbSQLServerLogo
            // 
            pbSQLServerLogo.BackColor = System.Drawing.SystemColors.Window;
            pbSQLServerLogo.BackgroundImage = DBMS_Services_Manager.Properties.Resources.SQL_Server_Logo_768x194;
            pbSQLServerLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pbSQLServerLogo.Location = new System.Drawing.Point(-1, -1);
            pbSQLServerLogo.Name = "pbSQLServerLogo";
            pbSQLServerLogo.Size = new System.Drawing.Size(131, 73);
            pbSQLServerLogo.TabIndex = 6;
            pbSQLServerLogo.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(btnRestartSQLServer);
            panel1.Controls.Add(btnStopSQLServer);
            panel1.Location = new System.Drawing.Point(146, 15);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(330, 37);
            panel1.TabIndex = 4;
            // 
            // btnRestartSQLServer
            // 
            btnRestartSQLServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRestartSQLServer.Image = DBMS_Services_Manager.Properties.Resources.Play;
            btnRestartSQLServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnRestartSQLServer.Location = new System.Drawing.Point(164, -1);
            btnRestartSQLServer.Name = "btnRestartSQLServer";
            btnRestartSQLServer.Size = new System.Drawing.Size(165, 37);
            btnRestartSQLServer.TabIndex = 0;
            btnRestartSQLServer.Text = "Reiniciar serviços";
            btnRestartSQLServer.UseVisualStyleBackColor = true;
            btnRestartSQLServer.Click += btnRestartSQLServer_Click;
            // 
            // btnStopSQLServer
            // 
            btnStopSQLServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStopSQLServer.Image = DBMS_Services_Manager.Properties.Resources.Abort;
            btnStopSQLServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnStopSQLServer.Location = new System.Drawing.Point(-1, -1);
            btnStopSQLServer.Name = "btnStopSQLServer";
            btnStopSQLServer.Size = new System.Drawing.Size(166, 37);
            btnStopSQLServer.TabIndex = 0;
            btnStopSQLServer.Text = "Parar serviços";
            btnStopSQLServer.UseVisualStyleBackColor = true;
            btnStopSQLServer.Click += BtnStopSQLServer_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlHeader.BackColor = System.Drawing.Color.White;
            pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pnlHeader.Controls.Add(lblApplicationName);
            pnlHeader.Controls.Add(btnAbout);
            pnlHeader.Controls.Add(pbDeveloperLogo);
            pnlHeader.Controls.Add(btnMinimize);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Location = new System.Drawing.Point(1, 1);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(645, 41);
            pnlHeader.TabIndex = 0;
            pnlHeader.MouseDown += pnlHeader_MouseDown;
            pnlHeader.MouseMove += pnlHeader_MouseMove;
            pnlHeader.MouseUp += pnlHeader_MouseUp;
            // 
            // lblApplicationName
            // 
            lblApplicationName.AutoSize = true;
            lblApplicationName.CausesValidation = false;
            lblApplicationName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblApplicationName.Location = new System.Drawing.Point(92, 7);
            lblApplicationName.Name = "lblApplicationName";
            lblApplicationName.Size = new System.Drawing.Size(217, 25);
            lblApplicationName.TabIndex = 2;
            lblApplicationName.Text = "DBMS Services Manager";
            // 
            // btnAbout
            // 
            btnAbout.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnAbout.BackColor = System.Drawing.Color.WhiteSmoke;
            btnAbout.FlatAppearance.BorderSize = 0;
            btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAbout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAbout.Location = new System.Drawing.Point(503, 7);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new System.Drawing.Size(65, 27);
            btnAbout.TabIndex = 1;
            btnAbout.Text = "Sobre";
            btnAbout.UseVisualStyleBackColor = false;
            btnAbout.Click += btnAbout_Click;
            // 
            // pbDeveloperLogo
            // 
            pbDeveloperLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pbDeveloperLogo.Enabled = false;
            pbDeveloperLogo.Image = DBMS_Services_Manager.Properties.Resources.vesoSoftware_Avatar;
            pbDeveloperLogo.Location = new System.Drawing.Point(6, -21);
            pbDeveloperLogo.Name = "pbDeveloperLogo";
            pbDeveloperLogo.Size = new System.Drawing.Size(83, 79);
            pbDeveloperLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbDeveloperLogo.TabIndex = 2;
            pbDeveloperLogo.TabStop = false;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            btnMinimize.BackColor = System.Drawing.Color.WhiteSmoke;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMinimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnMinimize.Location = new System.Drawing.Point(577, 7);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new System.Drawing.Size(28, 27);
            btnMinimize.TabIndex = 1;
            btnMinimize.Text = "_";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            btnClose.BackColor = System.Drawing.Color.Tomato;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Location = new System.Drawing.Point(605, 7);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(28, 27);
            btnClose.TabIndex = 2;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // tmrServiceStatusVerifier
            // 
            tmrServiceStatusVerifier.Tick += tmrServiceStatusVerifier_Tick;
            // 
            // btnStopAllServices
            // 
            btnStopAllServices.Anchor = System.Windows.Forms.AnchorStyles.Left;
            btnStopAllServices.BackColor = System.Drawing.Color.WhiteSmoke;
            btnStopAllServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStopAllServices.Image = DBMS_Services_Manager.Properties.Resources.Abort;
            btnStopAllServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnStopAllServices.Location = new System.Drawing.Point(-1, -1);
            btnStopAllServices.Name = "btnStopAllServices";
            btnStopAllServices.Size = new System.Drawing.Size(204, 37);
            btnStopAllServices.TabIndex = 0;
            btnStopAllServices.Text = "Parar todos os serviços";
            btnStopAllServices.UseVisualStyleBackColor = false;
            btnStopAllServices.Click += btnStopAllServices_Click;
            // 
            // btnRestartAllServices
            // 
            btnRestartAllServices.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnRestartAllServices.BackColor = System.Drawing.Color.WhiteSmoke;
            btnRestartAllServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRestartAllServices.Image = DBMS_Services_Manager.Properties.Resources.Play;
            btnRestartAllServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnRestartAllServices.Location = new System.Drawing.Point(206, -1);
            btnRestartAllServices.Name = "btnRestartAllServices";
            btnRestartAllServices.Size = new System.Drawing.Size(212, 37);
            btnRestartAllServices.TabIndex = 0;
            btnRestartAllServices.Text = "Reiniciar todos os serviços";
            btnRestartAllServices.UseVisualStyleBackColor = false;
            btnRestartAllServices.Click += btnRestartAllServices_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Snow;
            btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Linen;
            btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnExit.Location = new System.Drawing.Point(12, 606);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(622, 26);
            btnExit.TabIndex = 1;
            btnExit.Text = "Sair";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pnlServicesMainController
            // 
            pnlServicesMainController.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlServicesMainController.BackColor = System.Drawing.Color.LightGray;
            pnlServicesMainController.Controls.Add(pnlServicesControllerBorder);
            pnlServicesMainController.Location = new System.Drawing.Point(1, 77);
            pnlServicesMainController.Name = "pnlServicesMainController";
            pnlServicesMainController.Size = new System.Drawing.Size(645, 53);
            pnlServicesMainController.TabIndex = 8;
            // 
            // pnlServicesControllerBorder
            // 
            pnlServicesControllerBorder.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlServicesControllerBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlServicesControllerBorder.Controls.Add(btnStopAllServices);
            pnlServicesControllerBorder.Controls.Add(btnSettings);
            pnlServicesControllerBorder.Controls.Add(btnRestartAllServices);
            pnlServicesControllerBorder.Location = new System.Drawing.Point(11, 8);
            pnlServicesControllerBorder.Name = "pnlServicesControllerBorder";
            pnlServicesControllerBorder.Size = new System.Drawing.Size(622, 37);
            pnlServicesControllerBorder.TabIndex = 4;
            // 
            // btnSettings
            // 
            btnSettings.Anchor = System.Windows.Forms.AnchorStyles.Right;
            btnSettings.BackColor = System.Drawing.Color.AliceBlue;
            btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSettings.Image = DBMS_Services_Manager.Properties.Resources.pinion;
            btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSettings.Location = new System.Drawing.Point(421, -1);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new System.Drawing.Size(200, 37);
            btnSettings.TabIndex = 1;
            btnSettings.Text = "Configurações";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // lblQuickCommands
            // 
            lblQuickCommands.AutoSize = true;
            lblQuickCommands.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblQuickCommands.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblQuickCommands.Location = new System.Drawing.Point(256, 50);
            lblQuickCommands.Name = "lblQuickCommands";
            lblQuickCommands.Size = new System.Drawing.Size(134, 20);
            lblQuickCommands.TabIndex = 9;
            lblQuickCommands.Text = "Comandos rápidos";
            // 
            // lblManageServices
            // 
            lblManageServices.AutoSize = true;
            lblManageServices.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblManageServices.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblManageServices.Location = new System.Drawing.Point(221, 140);
            lblManageServices.Name = "lblManageServices";
            lblManageServices.Size = new System.Drawing.Size(205, 20);
            lblManageServices.TabIndex = 9;
            lblManageServices.Text = "Gerenciar estado dos serviços";
            // 
            // pnlServiceStatus
            // 
            pnlServiceStatus.BackColor = System.Drawing.Color.White;
            pnlServiceStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pnlServiceStatus.Controls.Add(lblServiceStatus);
            pnlServiceStatus.Location = new System.Drawing.Point(504, 140);
            pnlServiceStatus.Name = "pnlServiceStatus";
            pnlServiceStatus.Size = new System.Drawing.Size(131, 453);
            pnlServiceStatus.TabIndex = 10;
            pnlServiceStatus.Visible = false;
            // 
            // lblServiceStatus
            // 
            lblServiceStatus.AutoSize = true;
            lblServiceStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblServiceStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblServiceStatus.Location = new System.Drawing.Point(45, 10);
            lblServiceStatus.Name = "lblServiceStatus";
            lblServiceStatus.Size = new System.Drawing.Size(42, 15);
            lblServiceStatus.TabIndex = 0;
            lblServiceStatus.Text = "Status";
            // 
            // pnlFooter
            // 
            pnlFooter.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlFooter.BackColor = System.Drawing.Color.LightGray;
            pnlFooter.Location = new System.Drawing.Point(1, 599);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new System.Drawing.Size(645, 41);
            pnlFooter.TabIndex = 11;
            // 
            // pnlServiceLogo
            // 
            pnlServiceLogo.BackColor = System.Drawing.Color.White;
            pnlServiceLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pnlServiceLogo.Controls.Add(lblServices);
            pnlServiceLogo.Location = new System.Drawing.Point(11, 140);
            pnlServiceLogo.Name = "pnlServiceLogo";
            pnlServiceLogo.Size = new System.Drawing.Size(131, 453);
            pnlServiceLogo.TabIndex = 14;
            pnlServiceLogo.Visible = false;
            // 
            // lblServices
            // 
            lblServices.AutoSize = true;
            lblServices.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblServices.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblServices.Location = new System.Drawing.Point(37, 10);
            lblServices.Name = "lblServices";
            lblServices.Size = new System.Drawing.Size(54, 15);
            lblServices.TabIndex = 0;
            lblServices.Text = "Serviços";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(646, 645);
            ControlBox = false;
            Controls.Add(lblManageServices);
            Controls.Add(lblQuickCommands);
            Controls.Add(btnExit);
            Controls.Add(pnlMongoDB);
            Controls.Add(pnlHeader);
            Controls.Add(pnlServicesMainController);
            Controls.Add(pnlMariaDB);
            Controls.Add(pnlPostgreSQL);
            Controls.Add(pnlMySQL);
            Controls.Add(pnlFooter);
            Controls.Add(pnlSQLServer);
            Controls.Add(pnlServiceLogo);
            Controls.Add(pnlServiceStatus);
            DoubleBuffered = true;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPrincipal";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "DBMS Services Manager";
            Load += FrmPrincipal_Load;
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbMongoDBServiceStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMariaDBServiceStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPostgreSQLServiceStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMySQLServiceStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSQLServerServiceStatus).EndInit();
            pnlMongoDB.ResumeLayout(false);
            pnlMongoDB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbMongoDBLogo).EndInit();
            pnlMariaDB.ResumeLayout(false);
            pnlMariaDB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbMariaDBLogo).EndInit();
            pnlPostgreSQL.ResumeLayout(false);
            pnlPostgreSQL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPostgreSQLLogo).EndInit();
            pnlMySQL.ResumeLayout(false);
            pnlMySQL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbMySQLLogo).EndInit();
            pnlSQLServer.ResumeLayout(false);
            pnlSQLServer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSQLServerLogo).EndInit();
            panel1.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbDeveloperLogo).EndInit();
            pnlServicesMainController.ResumeLayout(false);
            pnlServicesControllerBorder.ResumeLayout(false);
            pnlServiceStatus.ResumeLayout(false);
            pnlServiceStatus.PerformLayout();
            pnlServiceLogo.ResumeLayout(false);
            pnlServiceLogo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public System.Windows.Forms.PictureBox pbSQLServerLogo;
        public System.Windows.Forms.PictureBox pbMariaDBLogo;
        public System.Windows.Forms.PictureBox pbPostgreSQLLogo;
        public System.Windows.Forms.PictureBox pbMySQLLogo;
        public System.Windows.Forms.PictureBox pbMongoDBLogo;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel pnlHeader;
        public System.Windows.Forms.Panel pnlMongoDB;
        public System.Windows.Forms.Panel pnlMariaDB;
        public System.Windows.Forms.Panel pnlPostgreSQL;
        public System.Windows.Forms.Timer tmrServiceStatusVerifier;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Panel pnlServicesControllerBorder;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblManageServices;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel pnlServiceStatus;
        public System.Windows.Forms.Label lblServiceStatus;
        public System.Windows.Forms.Panel pnlFooter;
        public System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.PictureBox pbSQLServerServiceStatus;
        private System.Windows.Forms.TextBox txtSQLServerServiceStatus;
        private System.Windows.Forms.Button btnRestartSQLServer;
        private System.Windows.Forms.Button btnStopSQLServer;
        private System.Windows.Forms.PictureBox pbMySQLServiceStatus;
        private System.Windows.Forms.TextBox txtMySQLServiceStatus;
        private System.Windows.Forms.Button btnRestartMySQL;
        private System.Windows.Forms.Button btnStopMySQL;
        private System.Windows.Forms.Panel pnlMySQL;
        private System.Windows.Forms.Panel pnlSQLServer;
        private System.Windows.Forms.Button btnStopMariaDB;
        private System.Windows.Forms.Button btnRestartPostgreSQL;
        private System.Windows.Forms.Button btnStopPostgreSQL;
        private System.Windows.Forms.Button btnRestartMariaDB;
        private System.Windows.Forms.PictureBox pbMongoDBServiceStatus;
        private System.Windows.Forms.PictureBox pbMariaDBServiceStatus;
        private System.Windows.Forms.PictureBox pbPostgreSQLServiceStatus;
        private System.Windows.Forms.TextBox txtPostgreSQLServiceStatus;
        private System.Windows.Forms.TextBox txtMongoDBServiceStatus;
        private System.Windows.Forms.Button btnRestartMongoDB;
        private System.Windows.Forms.Button btnStopMongoDB;
        private System.Windows.Forms.TextBox txtMariaDBServiceStatus;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        internal System.Windows.Forms.Label lblApplicationName;
        private System.Windows.Forms.PictureBox pbDeveloperLogo;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnRestartAllServices;
        private System.Windows.Forms.Button btnStopAllServices;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblQuickCommands;
        private System.Windows.Forms.Panel pnlServicesMainController;
        private System.Windows.Forms.Panel pnlServiceLogo;
    }
}

