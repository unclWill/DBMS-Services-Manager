namespace MachineStop
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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pnlMariaDB = new System.Windows.Forms.Panel();
            pbDB04Logo = new System.Windows.Forms.PictureBox();
            pnlPostgreSQL = new System.Windows.Forms.Panel();
            pbDB03Logo = new System.Windows.Forms.PictureBox();
            pnlMySQL = new System.Windows.Forms.Panel();
            pbDB02Logo = new System.Windows.Forms.PictureBox();
            pnlSQLServer = new System.Windows.Forms.Panel();
            pbDB01Logo = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            btnRestartSQLServer = new System.Windows.Forms.Button();
            btnStopSQLServer = new System.Windows.Forms.Button();
            pnlMachineStopHeader = new System.Windows.Forms.Panel();
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            pnlServiceStatus = new System.Windows.Forms.Panel();
            lblServiceStatus = new System.Windows.Forms.Label();
            panel8 = new System.Windows.Forms.Panel();
            panel6 = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlMariaDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDB04Logo).BeginInit();
            pnlPostgreSQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDB03Logo).BeginInit();
            pnlMySQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDB02Logo).BeginInit();
            pnlSQLServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDB01Logo).BeginInit();
            panel1.SuspendLayout();
            pnlMachineStopHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDeveloperLogo).BeginInit();
            pnlServicesMainController.SuspendLayout();
            pnlServicesControllerBorder.SuspendLayout();
            pnlServiceStatus.SuspendLayout();
            panel6.SuspendLayout();
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
            pnlMongoDB.Controls.Add(pictureBox1);
            pnlMongoDB.Location = new System.Drawing.Point(12, 519);
            pnlMongoDB.Name = "pnlMongoDB";
            pnlMongoDB.Size = new System.Drawing.Size(623, 71);
            pnlMongoDB.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            pictureBox1.BackgroundImage = DBMS_Services_Manager.Properties.Resources._2560px_MongoDB_Logo_svg;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Location = new System.Drawing.Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(131, 73);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pnlMariaDB
            // 
            pnlMariaDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            pnlMariaDB.BackColor = System.Drawing.Color.White;
            pnlMariaDB.Controls.Add(txtMariaDBServiceStatus);
            pnlMariaDB.Controls.Add(pbDB04Logo);
            pnlMariaDB.Controls.Add(pbMariaDBServiceStatus);
            pnlMariaDB.Controls.Add(panel4);
            pnlMariaDB.Location = new System.Drawing.Point(12, 432);
            pnlMariaDB.Name = "pnlMariaDB";
            pnlMariaDB.Size = new System.Drawing.Size(623, 71);
            pnlMariaDB.TabIndex = 8;
            // 
            // pbDB04Logo
            // 
            pbDB04Logo.BackColor = System.Drawing.SystemColors.Window;
            pbDB04Logo.BackgroundImage = DBMS_Services_Manager.Properties.Resources.Mariadb_seal_browntext_svg;
            pbDB04Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pbDB04Logo.Location = new System.Drawing.Point(-1, -1);
            pbDB04Logo.Name = "pbDB04Logo";
            pbDB04Logo.Size = new System.Drawing.Size(131, 73);
            pbDB04Logo.TabIndex = 6;
            pbDB04Logo.TabStop = false;
            // 
            // pnlPostgreSQL
            // 
            pnlPostgreSQL.Anchor = System.Windows.Forms.AnchorStyles.None;
            pnlPostgreSQL.BackColor = System.Drawing.Color.White;
            pnlPostgreSQL.Controls.Add(txtPostgreSQLServiceStatus);
            pnlPostgreSQL.Controls.Add(pbDB03Logo);
            pnlPostgreSQL.Controls.Add(panel3);
            pnlPostgreSQL.Controls.Add(pbPostgreSQLServiceStatus);
            pnlPostgreSQL.Location = new System.Drawing.Point(12, 344);
            pnlPostgreSQL.Name = "pnlPostgreSQL";
            pnlPostgreSQL.Size = new System.Drawing.Size(623, 71);
            pnlPostgreSQL.TabIndex = 8;
            // 
            // pbDB03Logo
            // 
            pbDB03Logo.BackColor = System.Drawing.SystemColors.Window;
            pbDB03Logo.BackgroundImage = DBMS_Services_Manager.Properties.Resources._242_2423721_logo_postgresql;
            pbDB03Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pbDB03Logo.Location = new System.Drawing.Point(-1, -1);
            pbDB03Logo.Name = "pbDB03Logo";
            pbDB03Logo.Size = new System.Drawing.Size(131, 73);
            pbDB03Logo.TabIndex = 6;
            pbDB03Logo.TabStop = false;
            // 
            // pnlMySQL
            // 
            pnlMySQL.Anchor = System.Windows.Forms.AnchorStyles.None;
            pnlMySQL.BackColor = System.Drawing.Color.White;
            pnlMySQL.Controls.Add(txtMySQLServiceStatus);
            pnlMySQL.Controls.Add(panel2);
            pnlMySQL.Controls.Add(pbDB02Logo);
            pnlMySQL.Controls.Add(pbMySQLServiceStatus);
            pnlMySQL.Location = new System.Drawing.Point(12, 256);
            pnlMySQL.Name = "pnlMySQL";
            pnlMySQL.Size = new System.Drawing.Size(623, 71);
            pnlMySQL.TabIndex = 8;
            // 
            // pbDB02Logo
            // 
            pbDB02Logo.BackColor = System.Drawing.SystemColors.Window;
            pbDB02Logo.BackgroundImage = DBMS_Services_Manager.Properties.Resources.Mysql_logo;
            pbDB02Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pbDB02Logo.Location = new System.Drawing.Point(-1, -2);
            pbDB02Logo.Name = "pbDB02Logo";
            pbDB02Logo.Size = new System.Drawing.Size(131, 74);
            pbDB02Logo.TabIndex = 6;
            pbDB02Logo.TabStop = false;
            // 
            // pnlSQLServer
            // 
            pnlSQLServer.Anchor = System.Windows.Forms.AnchorStyles.None;
            pnlSQLServer.BackColor = System.Drawing.Color.White;
            pnlSQLServer.Controls.Add(pbDB01Logo);
            pnlSQLServer.Controls.Add(pbSQLServerServiceStatus);
            pnlSQLServer.Controls.Add(txtSQLServerServiceStatus);
            pnlSQLServer.Controls.Add(panel1);
            pnlSQLServer.Location = new System.Drawing.Point(12, 169);
            pnlSQLServer.Name = "pnlSQLServer";
            pnlSQLServer.Size = new System.Drawing.Size(623, 71);
            pnlSQLServer.TabIndex = 8;
            // 
            // pbDB01Logo
            // 
            pbDB01Logo.BackColor = System.Drawing.SystemColors.Window;
            pbDB01Logo.BackgroundImage = DBMS_Services_Manager.Properties.Resources.SQL_Server_Logo_768x194;
            pbDB01Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pbDB01Logo.Location = new System.Drawing.Point(-1, -1);
            pbDB01Logo.Name = "pbDB01Logo";
            pbDB01Logo.Size = new System.Drawing.Size(131, 73);
            pbDB01Logo.TabIndex = 6;
            pbDB01Logo.TabStop = false;
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
            // pnlMachineStopHeader
            // 
            pnlMachineStopHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlMachineStopHeader.BackColor = System.Drawing.Color.White;
            pnlMachineStopHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pnlMachineStopHeader.Controls.Add(lblApplicationName);
            pnlMachineStopHeader.Controls.Add(btnAbout);
            pnlMachineStopHeader.Controls.Add(pbDeveloperLogo);
            pnlMachineStopHeader.Controls.Add(btnMinimize);
            pnlMachineStopHeader.Controls.Add(btnClose);
            pnlMachineStopHeader.Location = new System.Drawing.Point(1, 1);
            pnlMachineStopHeader.Name = "pnlMachineStopHeader";
            pnlMachineStopHeader.Size = new System.Drawing.Size(645, 41);
            pnlMachineStopHeader.TabIndex = 0;
            pnlMachineStopHeader.MouseDown += pnlMachineStopHeader_MouseDown;
            pnlMachineStopHeader.MouseMove += pnlMachineStopHeader_MouseMove;
            pnlMachineStopHeader.MouseUp += pnlMachineStopHeader_MouseUp;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label1.Location = new System.Drawing.Point(256, 50);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(134, 20);
            label1.TabIndex = 9;
            label1.Text = "Comandos rápidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label2.Location = new System.Drawing.Point(221, 140);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(205, 20);
            label2.TabIndex = 9;
            label2.Text = "Gerenciar estado dos serviços";
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
            // panel8
            // 
            panel8.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel8.BackColor = System.Drawing.Color.LightGray;
            panel8.Location = new System.Drawing.Point(1, 599);
            panel8.Name = "panel8";
            panel8.Size = new System.Drawing.Size(645, 41);
            panel8.TabIndex = 11;
            // 
            // panel6
            // 
            panel6.BackColor = System.Drawing.Color.White;
            panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            panel6.Controls.Add(label4);
            panel6.Location = new System.Drawing.Point(11, 140);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(131, 453);
            panel6.TabIndex = 14;
            panel6.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label4.Location = new System.Drawing.Point(37, 10);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(54, 15);
            label4.TabIndex = 0;
            label4.Text = "Serviços";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(646, 645);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(pnlMongoDB);
            Controls.Add(pnlMachineStopHeader);
            Controls.Add(pnlServicesMainController);
            Controls.Add(pnlMariaDB);
            Controls.Add(pnlPostgreSQL);
            Controls.Add(pnlMySQL);
            Controls.Add(panel8);
            Controls.Add(pnlSQLServer);
            Controls.Add(panel6);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlMariaDB.ResumeLayout(false);
            pnlMariaDB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbDB04Logo).EndInit();
            pnlPostgreSQL.ResumeLayout(false);
            pnlPostgreSQL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbDB03Logo).EndInit();
            pnlMySQL.ResumeLayout(false);
            pnlMySQL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbDB02Logo).EndInit();
            pnlSQLServer.ResumeLayout(false);
            pnlSQLServer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbDB01Logo).EndInit();
            panel1.ResumeLayout(false);
            pnlMachineStopHeader.ResumeLayout(false);
            pnlMachineStopHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbDeveloperLogo).EndInit();
            pnlServicesMainController.ResumeLayout(false);
            pnlServicesControllerBorder.ResumeLayout(false);
            pnlServiceStatus.ResumeLayout(false);
            pnlServiceStatus.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public System.Windows.Forms.PictureBox pbDB01Logo;
        public System.Windows.Forms.PictureBox pbDB04Logo;
        public System.Windows.Forms.PictureBox pbDB03Logo;
        public System.Windows.Forms.PictureBox pbDB02Logo;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Button btnStopMariaDB;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button btnRestartPostgreSQL;
        public System.Windows.Forms.Button btnStopPostgreSQL;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnRestartMySQL;
        public System.Windows.Forms.Button btnStopMySQL;
        public System.Windows.Forms.Button btnRestartMariaDB;
        public System.Windows.Forms.Panel pnlMachineStopHeader;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnMinimize;
        public System.Windows.Forms.Panel pnlMongoDB;
        public System.Windows.Forms.Panel pnlMariaDB;
        public System.Windows.Forms.Panel pnlPostgreSQL;
        public System.Windows.Forms.Panel pnlMySQL;
        public System.Windows.Forms.Panel pnlSQLServer;
        public System.Windows.Forms.Label lblApplicationName;
        public System.Windows.Forms.PictureBox pbMongoDBServiceStatus;
        public System.Windows.Forms.PictureBox pbMariaDBServiceStatus;
        public System.Windows.Forms.PictureBox pbPostgreSQLServiceStatus;
        public System.Windows.Forms.PictureBox pbMySQLServiceStatus;
        public System.Windows.Forms.PictureBox pbSQLServerServiceStatus;
        public System.Windows.Forms.Timer tmrServiceStatusVerifier;
        public System.Windows.Forms.TextBox txtPostgreSQLServiceStatus;
        public System.Windows.Forms.TextBox txtMySQLServiceStatus;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.TextBox txtMongoDBServiceStatus;
        public System.Windows.Forms.Button btnRestartMongoDB;
        public System.Windows.Forms.Button btnStopMongoDB;
        public System.Windows.Forms.TextBox txtMariaDBServiceStatus;
        public System.Windows.Forms.TextBox txtSQLServerServiceStatus;
        public System.Windows.Forms.PictureBox pbDeveloperLogo;
        public System.Windows.Forms.Button btnAbout;
        public System.Windows.Forms.Button btnRestartAllServices;
        public System.Windows.Forms.Button btnStopAllServices;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Panel pnlServicesMainController;
        public System.Windows.Forms.Panel pnlServicesControllerBorder;
        public System.Windows.Forms.Button btnSettings;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnRestartSQLServer;
        public System.Windows.Forms.Button btnStopSQLServer;
        public System.Windows.Forms.Panel pnlServiceStatus;
        public System.Windows.Forms.Label lblServiceStatus;
        public System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Label label4;
    }
}

