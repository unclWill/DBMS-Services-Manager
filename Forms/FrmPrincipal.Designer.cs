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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRestartMySQL = new System.Windows.Forms.Button();
            this.btnStopMySQL = new System.Windows.Forms.Button();
            this.txtMySQLServiceStatus = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRestartMongoDB = new System.Windows.Forms.Button();
            this.btnStopMongoDB = new System.Windows.Forms.Button();
            this.txtMongoDBServiceStatus = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRestartMariaDB = new System.Windows.Forms.Button();
            this.btnStopMariaDB = new System.Windows.Forms.Button();
            this.txtMariaDBServiceStatus = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRestartPostgreSQL = new System.Windows.Forms.Button();
            this.btnStopPostgreSQL = new System.Windows.Forms.Button();
            this.txtPostgreSQLServiceStatus = new System.Windows.Forms.TextBox();
            this.txtSQLServerServiceStatus = new System.Windows.Forms.TextBox();
            this.pbMongoDBServiceStatus = new System.Windows.Forms.PictureBox();
            this.pbMariaDBServiceStatus = new System.Windows.Forms.PictureBox();
            this.pbPostgreSQLServiceStatus = new System.Windows.Forms.PictureBox();
            this.pbMySQLServiceStatus = new System.Windows.Forms.PictureBox();
            this.pbSQLServerServiceStatus = new System.Windows.Forms.PictureBox();
            this.pnlMongoDB = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMariaDB = new System.Windows.Forms.Panel();
            this.pbDB04Logo = new System.Windows.Forms.PictureBox();
            this.pnlPostgreSQL = new System.Windows.Forms.Panel();
            this.pbDB03Logo = new System.Windows.Forms.PictureBox();
            this.pnlMySQL = new System.Windows.Forms.Panel();
            this.pbDB02Logo = new System.Windows.Forms.PictureBox();
            this.pnlSQLServer = new System.Windows.Forms.Panel();
            this.pbDB01Logo = new System.Windows.Forms.PictureBox();
            this.lblRunningServicesCounter = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRestartSQLServer = new System.Windows.Forms.Button();
            this.btnStopSQLServer = new System.Windows.Forms.Button();
            this.pnlMachineStopHeader = new System.Windows.Forms.Panel();
            this.lblApplicationName = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.pbDeveloperLogo = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tmrServiceStatusVerifier = new System.Windows.Forms.Timer(this.components);
            this.btnStopAllServices = new System.Windows.Forms.Button();
            this.btnRestartAllServices = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlServicesMainController = new System.Windows.Forms.Panel();
            this.pnlServicesControllerBorder = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlServiceStatus = new System.Windows.Forms.Panel();
            this.lblServiceStatus = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblTimerStatus = new System.Windows.Forms.Label();
            this.btnStopTimer = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMongoDBServiceStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMariaDBServiceStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPostgreSQLServiceStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMySQLServiceStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSQLServerServiceStatus)).BeginInit();
            this.pnlMongoDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMariaDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDB04Logo)).BeginInit();
            this.pnlPostgreSQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDB03Logo)).BeginInit();
            this.pnlMySQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDB02Logo)).BeginInit();
            this.pnlSQLServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDB01Logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlMachineStopHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeveloperLogo)).BeginInit();
            this.pnlServicesMainController.SuspendLayout();
            this.pnlServicesControllerBorder.SuspendLayout();
            this.pnlServiceStatus.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnRestartMySQL);
            this.panel2.Controls.Add(this.btnStopMySQL);
            this.panel2.Location = new System.Drawing.Point(146, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 37);
            this.panel2.TabIndex = 4;
            // 
            // btnRestartMySQL
            // 
            this.btnRestartMySQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestartMySQL.Image = global::DBMS_Services_Manager.Properties.Resources.Play;
            this.btnRestartMySQL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestartMySQL.Location = new System.Drawing.Point(164, -1);
            this.btnRestartMySQL.Name = "btnRestartMySQL";
            this.btnRestartMySQL.Size = new System.Drawing.Size(165, 37);
            this.btnRestartMySQL.TabIndex = 0;
            this.btnRestartMySQL.Text = "Reiniciar serviços";
            this.btnRestartMySQL.UseVisualStyleBackColor = true;
            this.btnRestartMySQL.Click += new System.EventHandler(this.btnRestartMySQL_Click);
            // 
            // btnStopMySQL
            // 
            this.btnStopMySQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopMySQL.Image = global::DBMS_Services_Manager.Properties.Resources.Abort;
            this.btnStopMySQL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStopMySQL.Location = new System.Drawing.Point(-1, -1);
            this.btnStopMySQL.Name = "btnStopMySQL";
            this.btnStopMySQL.Size = new System.Drawing.Size(166, 37);
            this.btnStopMySQL.TabIndex = 0;
            this.btnStopMySQL.Text = "Parar serviços";
            this.btnStopMySQL.UseVisualStyleBackColor = true;
            this.btnStopMySQL.Click += new System.EventHandler(this.btnStopMySQL_Click);
            // 
            // txtMySQLServiceStatus
            // 
            this.txtMySQLServiceStatus.BackColor = System.Drawing.Color.White;
            this.txtMySQLServiceStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMySQLServiceStatus.Enabled = false;
            this.txtMySQLServiceStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMySQLServiceStatus.Location = new System.Drawing.Point(507, 43);
            this.txtMySQLServiceStatus.Name = "txtMySQLServiceStatus";
            this.txtMySQLServiceStatus.ReadOnly = true;
            this.txtMySQLServiceStatus.Size = new System.Drawing.Size(101, 16);
            this.txtMySQLServiceStatus.TabIndex = 5;
            this.txtMySQLServiceStatus.TabStop = false;
            this.txtMySQLServiceStatus.Text = "Status";
            this.txtMySQLServiceStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnRestartMongoDB);
            this.panel5.Controls.Add(this.btnStopMongoDB);
            this.panel5.Location = new System.Drawing.Point(146, 15);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(330, 37);
            this.panel5.TabIndex = 4;
            // 
            // btnRestartMongoDB
            // 
            this.btnRestartMongoDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestartMongoDB.Image = global::DBMS_Services_Manager.Properties.Resources.Play;
            this.btnRestartMongoDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestartMongoDB.Location = new System.Drawing.Point(164, -1);
            this.btnRestartMongoDB.Name = "btnRestartMongoDB";
            this.btnRestartMongoDB.Size = new System.Drawing.Size(165, 37);
            this.btnRestartMongoDB.TabIndex = 0;
            this.btnRestartMongoDB.Text = "Reiniciar serviços";
            this.btnRestartMongoDB.UseVisualStyleBackColor = true;
            this.btnRestartMongoDB.Click += new System.EventHandler(this.btnRestartMongoDB_Click);
            // 
            // btnStopMongoDB
            // 
            this.btnStopMongoDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopMongoDB.Image = global::DBMS_Services_Manager.Properties.Resources.Abort;
            this.btnStopMongoDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStopMongoDB.Location = new System.Drawing.Point(-1, -1);
            this.btnStopMongoDB.Name = "btnStopMongoDB";
            this.btnStopMongoDB.Size = new System.Drawing.Size(166, 37);
            this.btnStopMongoDB.TabIndex = 0;
            this.btnStopMongoDB.Text = "Parar serviços";
            this.btnStopMongoDB.UseVisualStyleBackColor = true;
            this.btnStopMongoDB.Click += new System.EventHandler(this.btnStopMongoDB_Click);
            // 
            // txtMongoDBServiceStatus
            // 
            this.txtMongoDBServiceStatus.BackColor = System.Drawing.Color.White;
            this.txtMongoDBServiceStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMongoDBServiceStatus.Enabled = false;
            this.txtMongoDBServiceStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMongoDBServiceStatus.Location = new System.Drawing.Point(507, 43);
            this.txtMongoDBServiceStatus.Name = "txtMongoDBServiceStatus";
            this.txtMongoDBServiceStatus.ReadOnly = true;
            this.txtMongoDBServiceStatus.Size = new System.Drawing.Size(101, 16);
            this.txtMongoDBServiceStatus.TabIndex = 5;
            this.txtMongoDBServiceStatus.TabStop = false;
            this.txtMongoDBServiceStatus.Text = "Status";
            this.txtMongoDBServiceStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnRestartMariaDB);
            this.panel4.Controls.Add(this.btnStopMariaDB);
            this.panel4.Location = new System.Drawing.Point(146, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(330, 37);
            this.panel4.TabIndex = 4;
            // 
            // btnRestartMariaDB
            // 
            this.btnRestartMariaDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestartMariaDB.Image = global::DBMS_Services_Manager.Properties.Resources.Play;
            this.btnRestartMariaDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestartMariaDB.Location = new System.Drawing.Point(164, -1);
            this.btnRestartMariaDB.Name = "btnRestartMariaDB";
            this.btnRestartMariaDB.Size = new System.Drawing.Size(165, 37);
            this.btnRestartMariaDB.TabIndex = 0;
            this.btnRestartMariaDB.Text = "Reiniciar serviços";
            this.btnRestartMariaDB.UseVisualStyleBackColor = true;
            this.btnRestartMariaDB.Click += new System.EventHandler(this.btnRestartMariaDB_Click);
            // 
            // btnStopMariaDB
            // 
            this.btnStopMariaDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopMariaDB.Image = global::DBMS_Services_Manager.Properties.Resources.Abort;
            this.btnStopMariaDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStopMariaDB.Location = new System.Drawing.Point(-1, -1);
            this.btnStopMariaDB.Name = "btnStopMariaDB";
            this.btnStopMariaDB.Size = new System.Drawing.Size(166, 37);
            this.btnStopMariaDB.TabIndex = 0;
            this.btnStopMariaDB.Text = "Parar serviços";
            this.btnStopMariaDB.UseVisualStyleBackColor = true;
            this.btnStopMariaDB.Click += new System.EventHandler(this.btnStopMariaDB_Click);
            // 
            // txtMariaDBServiceStatus
            // 
            this.txtMariaDBServiceStatus.BackColor = System.Drawing.Color.White;
            this.txtMariaDBServiceStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMariaDBServiceStatus.Enabled = false;
            this.txtMariaDBServiceStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMariaDBServiceStatus.Location = new System.Drawing.Point(507, 43);
            this.txtMariaDBServiceStatus.Name = "txtMariaDBServiceStatus";
            this.txtMariaDBServiceStatus.ReadOnly = true;
            this.txtMariaDBServiceStatus.Size = new System.Drawing.Size(101, 16);
            this.txtMariaDBServiceStatus.TabIndex = 5;
            this.txtMariaDBServiceStatus.TabStop = false;
            this.txtMariaDBServiceStatus.Text = "Status";
            this.txtMariaDBServiceStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnRestartPostgreSQL);
            this.panel3.Controls.Add(this.btnStopPostgreSQL);
            this.panel3.Location = new System.Drawing.Point(146, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(330, 37);
            this.panel3.TabIndex = 4;
            // 
            // btnRestartPostgreSQL
            // 
            this.btnRestartPostgreSQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestartPostgreSQL.Image = global::DBMS_Services_Manager.Properties.Resources.Play;
            this.btnRestartPostgreSQL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestartPostgreSQL.Location = new System.Drawing.Point(164, -1);
            this.btnRestartPostgreSQL.Name = "btnRestartPostgreSQL";
            this.btnRestartPostgreSQL.Size = new System.Drawing.Size(165, 37);
            this.btnRestartPostgreSQL.TabIndex = 0;
            this.btnRestartPostgreSQL.Text = "Reiniciar serviços";
            this.btnRestartPostgreSQL.UseVisualStyleBackColor = true;
            this.btnRestartPostgreSQL.Click += new System.EventHandler(this.btnRestartPostgreSQL_Click);
            // 
            // btnStopPostgreSQL
            // 
            this.btnStopPostgreSQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopPostgreSQL.Image = global::DBMS_Services_Manager.Properties.Resources.Abort;
            this.btnStopPostgreSQL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStopPostgreSQL.Location = new System.Drawing.Point(-1, -1);
            this.btnStopPostgreSQL.Name = "btnStopPostgreSQL";
            this.btnStopPostgreSQL.Size = new System.Drawing.Size(166, 37);
            this.btnStopPostgreSQL.TabIndex = 0;
            this.btnStopPostgreSQL.Text = "Parar serviços";
            this.btnStopPostgreSQL.UseVisualStyleBackColor = true;
            this.btnStopPostgreSQL.Click += new System.EventHandler(this.btnStopPostgreSQL_Click);
            // 
            // txtPostgreSQLServiceStatus
            // 
            this.txtPostgreSQLServiceStatus.BackColor = System.Drawing.Color.White;
            this.txtPostgreSQLServiceStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPostgreSQLServiceStatus.Enabled = false;
            this.txtPostgreSQLServiceStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPostgreSQLServiceStatus.Location = new System.Drawing.Point(507, 43);
            this.txtPostgreSQLServiceStatus.Name = "txtPostgreSQLServiceStatus";
            this.txtPostgreSQLServiceStatus.ReadOnly = true;
            this.txtPostgreSQLServiceStatus.Size = new System.Drawing.Size(101, 16);
            this.txtPostgreSQLServiceStatus.TabIndex = 4;
            this.txtPostgreSQLServiceStatus.TabStop = false;
            this.txtPostgreSQLServiceStatus.Text = "Status";
            this.txtPostgreSQLServiceStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSQLServerServiceStatus
            // 
            this.txtSQLServerServiceStatus.BackColor = System.Drawing.Color.White;
            this.txtSQLServerServiceStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSQLServerServiceStatus.Enabled = false;
            this.txtSQLServerServiceStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSQLServerServiceStatus.Location = new System.Drawing.Point(507, 43);
            this.txtSQLServerServiceStatus.Name = "txtSQLServerServiceStatus";
            this.txtSQLServerServiceStatus.ReadOnly = true;
            this.txtSQLServerServiceStatus.Size = new System.Drawing.Size(101, 16);
            this.txtSQLServerServiceStatus.TabIndex = 5;
            this.txtSQLServerServiceStatus.TabStop = false;
            this.txtSQLServerServiceStatus.Text = "Status";
            this.txtSQLServerServiceStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbMongoDBServiceStatus
            // 
            this.pbMongoDBServiceStatus.BackgroundImage = global::DBMS_Services_Manager.Properties.Resources.Danger;
            this.pbMongoDBServiceStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbMongoDBServiceStatus.Location = new System.Drawing.Point(531, 7);
            this.pbMongoDBServiceStatus.Name = "pbMongoDBServiceStatus";
            this.pbMongoDBServiceStatus.Size = new System.Drawing.Size(54, 32);
            this.pbMongoDBServiceStatus.TabIndex = 3;
            this.pbMongoDBServiceStatus.TabStop = false;
            // 
            // pbMariaDBServiceStatus
            // 
            this.pbMariaDBServiceStatus.BackgroundImage = global::DBMS_Services_Manager.Properties.Resources.Danger;
            this.pbMariaDBServiceStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbMariaDBServiceStatus.Location = new System.Drawing.Point(531, 7);
            this.pbMariaDBServiceStatus.Name = "pbMariaDBServiceStatus";
            this.pbMariaDBServiceStatus.Size = new System.Drawing.Size(54, 32);
            this.pbMariaDBServiceStatus.TabIndex = 3;
            this.pbMariaDBServiceStatus.TabStop = false;
            // 
            // pbPostgreSQLServiceStatus
            // 
            this.pbPostgreSQLServiceStatus.BackgroundImage = global::DBMS_Services_Manager.Properties.Resources.Delete;
            this.pbPostgreSQLServiceStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbPostgreSQLServiceStatus.Location = new System.Drawing.Point(531, 7);
            this.pbPostgreSQLServiceStatus.Name = "pbPostgreSQLServiceStatus";
            this.pbPostgreSQLServiceStatus.Size = new System.Drawing.Size(54, 32);
            this.pbPostgreSQLServiceStatus.TabIndex = 3;
            this.pbPostgreSQLServiceStatus.TabStop = false;
            // 
            // pbMySQLServiceStatus
            // 
            this.pbMySQLServiceStatus.BackgroundImage = global::DBMS_Services_Manager.Properties.Resources.Danger;
            this.pbMySQLServiceStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbMySQLServiceStatus.Location = new System.Drawing.Point(531, 7);
            this.pbMySQLServiceStatus.Name = "pbMySQLServiceStatus";
            this.pbMySQLServiceStatus.Size = new System.Drawing.Size(54, 32);
            this.pbMySQLServiceStatus.TabIndex = 3;
            this.pbMySQLServiceStatus.TabStop = false;
            // 
            // pbSQLServerServiceStatus
            // 
            this.pbSQLServerServiceStatus.BackgroundImage = global::DBMS_Services_Manager.Properties.Resources.Danger;
            this.pbSQLServerServiceStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbSQLServerServiceStatus.Location = new System.Drawing.Point(531, 7);
            this.pbSQLServerServiceStatus.Name = "pbSQLServerServiceStatus";
            this.pbSQLServerServiceStatus.Size = new System.Drawing.Size(54, 32);
            this.pbSQLServerServiceStatus.TabIndex = 3;
            this.pbSQLServerServiceStatus.TabStop = false;
            // 
            // pnlMongoDB
            // 
            this.pnlMongoDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMongoDB.BackColor = System.Drawing.Color.White;
            this.pnlMongoDB.Controls.Add(this.txtMongoDBServiceStatus);
            this.pnlMongoDB.Controls.Add(this.pbMongoDBServiceStatus);
            this.pnlMongoDB.Controls.Add(this.panel5);
            this.pnlMongoDB.Controls.Add(this.pictureBox1);
            this.pnlMongoDB.Location = new System.Drawing.Point(12, 519);
            this.pnlMongoDB.Name = "pnlMongoDB";
            this.pnlMongoDB.Size = new System.Drawing.Size(623, 71);
            this.pnlMongoDB.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BackgroundImage = global::DBMS_Services_Manager.Properties.Resources._2560px_MongoDB_Logo_svg;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 73);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pnlMariaDB
            // 
            this.pnlMariaDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMariaDB.BackColor = System.Drawing.Color.White;
            this.pnlMariaDB.Controls.Add(this.txtMariaDBServiceStatus);
            this.pnlMariaDB.Controls.Add(this.pbDB04Logo);
            this.pnlMariaDB.Controls.Add(this.pbMariaDBServiceStatus);
            this.pnlMariaDB.Controls.Add(this.panel4);
            this.pnlMariaDB.Location = new System.Drawing.Point(12, 432);
            this.pnlMariaDB.Name = "pnlMariaDB";
            this.pnlMariaDB.Size = new System.Drawing.Size(623, 71);
            this.pnlMariaDB.TabIndex = 8;
            // 
            // pbDB04Logo
            // 
            this.pbDB04Logo.BackColor = System.Drawing.SystemColors.Window;
            this.pbDB04Logo.BackgroundImage = global::DBMS_Services_Manager.Properties.Resources.Mariadb_seal_browntext_svg;
            this.pbDB04Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbDB04Logo.Location = new System.Drawing.Point(-1, -1);
            this.pbDB04Logo.Name = "pbDB04Logo";
            this.pbDB04Logo.Size = new System.Drawing.Size(131, 73);
            this.pbDB04Logo.TabIndex = 6;
            this.pbDB04Logo.TabStop = false;
            // 
            // pnlPostgreSQL
            // 
            this.pnlPostgreSQL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPostgreSQL.BackColor = System.Drawing.Color.White;
            this.pnlPostgreSQL.Controls.Add(this.txtPostgreSQLServiceStatus);
            this.pnlPostgreSQL.Controls.Add(this.pbDB03Logo);
            this.pnlPostgreSQL.Controls.Add(this.panel3);
            this.pnlPostgreSQL.Controls.Add(this.pbPostgreSQLServiceStatus);
            this.pnlPostgreSQL.Location = new System.Drawing.Point(12, 344);
            this.pnlPostgreSQL.Name = "pnlPostgreSQL";
            this.pnlPostgreSQL.Size = new System.Drawing.Size(623, 71);
            this.pnlPostgreSQL.TabIndex = 8;
            // 
            // pbDB03Logo
            // 
            this.pbDB03Logo.BackColor = System.Drawing.SystemColors.Window;
            this.pbDB03Logo.BackgroundImage = global::DBMS_Services_Manager.Properties.Resources._242_2423721_logo_postgresql;
            this.pbDB03Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbDB03Logo.Location = new System.Drawing.Point(-1, -1);
            this.pbDB03Logo.Name = "pbDB03Logo";
            this.pbDB03Logo.Size = new System.Drawing.Size(131, 73);
            this.pbDB03Logo.TabIndex = 6;
            this.pbDB03Logo.TabStop = false;
            // 
            // pnlMySQL
            // 
            this.pnlMySQL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMySQL.BackColor = System.Drawing.Color.White;
            this.pnlMySQL.Controls.Add(this.txtMySQLServiceStatus);
            this.pnlMySQL.Controls.Add(this.panel2);
            this.pnlMySQL.Controls.Add(this.pbDB02Logo);
            this.pnlMySQL.Controls.Add(this.pbMySQLServiceStatus);
            this.pnlMySQL.Location = new System.Drawing.Point(12, 256);
            this.pnlMySQL.Name = "pnlMySQL";
            this.pnlMySQL.Size = new System.Drawing.Size(623, 71);
            this.pnlMySQL.TabIndex = 8;
            // 
            // pbDB02Logo
            // 
            this.pbDB02Logo.BackColor = System.Drawing.SystemColors.Window;
            this.pbDB02Logo.BackgroundImage = global::DBMS_Services_Manager.Properties.Resources.Mysql_logo;
            this.pbDB02Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbDB02Logo.Location = new System.Drawing.Point(-1, -2);
            this.pbDB02Logo.Name = "pbDB02Logo";
            this.pbDB02Logo.Size = new System.Drawing.Size(131, 74);
            this.pbDB02Logo.TabIndex = 6;
            this.pbDB02Logo.TabStop = false;
            // 
            // pnlSQLServer
            // 
            this.pnlSQLServer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSQLServer.BackColor = System.Drawing.Color.White;
            this.pnlSQLServer.Controls.Add(this.pbDB01Logo);
            this.pnlSQLServer.Controls.Add(this.pbSQLServerServiceStatus);
            this.pnlSQLServer.Controls.Add(this.lblRunningServicesCounter);
            this.pnlSQLServer.Controls.Add(this.label3);
            this.pnlSQLServer.Controls.Add(this.txtSQLServerServiceStatus);
            this.pnlSQLServer.Controls.Add(this.panel1);
            this.pnlSQLServer.Location = new System.Drawing.Point(12, 169);
            this.pnlSQLServer.Name = "pnlSQLServer";
            this.pnlSQLServer.Size = new System.Drawing.Size(623, 71);
            this.pnlSQLServer.TabIndex = 8;
            // 
            // pbDB01Logo
            // 
            this.pbDB01Logo.BackColor = System.Drawing.SystemColors.Window;
            this.pbDB01Logo.BackgroundImage = global::DBMS_Services_Manager.Properties.Resources.SQL_Server_Logo_768x194;
            this.pbDB01Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbDB01Logo.Location = new System.Drawing.Point(-1, -1);
            this.pbDB01Logo.Name = "pbDB01Logo";
            this.pbDB01Logo.Size = new System.Drawing.Size(131, 73);
            this.pbDB01Logo.TabIndex = 6;
            this.pbDB01Logo.TabStop = false;
            // 
            // lblRunningServicesCounter
            // 
            this.lblRunningServicesCounter.AutoSize = true;
            this.lblRunningServicesCounter.ForeColor = System.Drawing.Color.Red;
            this.lblRunningServicesCounter.Location = new System.Drawing.Point(367, 55);
            this.lblRunningServicesCounter.Name = "lblRunningServicesCounter";
            this.lblRunningServicesCounter.Size = new System.Drawing.Size(47, 15);
            this.lblRunningServicesCounter.TabIndex = 8;
            this.lblRunningServicesCounter.Text = "VALUES";
            this.lblRunningServicesCounter.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(231, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "SERVIÇOS EM EXECUÇÃO:";
            this.label3.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnRestartSQLServer);
            this.panel1.Controls.Add(this.btnStopSQLServer);
            this.panel1.Location = new System.Drawing.Point(146, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 37);
            this.panel1.TabIndex = 4;
            // 
            // btnRestartSQLServer
            // 
            this.btnRestartSQLServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestartSQLServer.Image = global::DBMS_Services_Manager.Properties.Resources.Play;
            this.btnRestartSQLServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestartSQLServer.Location = new System.Drawing.Point(164, -1);
            this.btnRestartSQLServer.Name = "btnRestartSQLServer";
            this.btnRestartSQLServer.Size = new System.Drawing.Size(165, 37);
            this.btnRestartSQLServer.TabIndex = 0;
            this.btnRestartSQLServer.Text = "Reiniciar serviços";
            this.btnRestartSQLServer.UseVisualStyleBackColor = true;
            this.btnRestartSQLServer.Click += new System.EventHandler(this.btnRestartSQLServer_Click);
            // 
            // btnStopSQLServer
            // 
            this.btnStopSQLServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopSQLServer.Image = global::DBMS_Services_Manager.Properties.Resources.Abort;
            this.btnStopSQLServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStopSQLServer.Location = new System.Drawing.Point(-1, -1);
            this.btnStopSQLServer.Name = "btnStopSQLServer";
            this.btnStopSQLServer.Size = new System.Drawing.Size(166, 37);
            this.btnStopSQLServer.TabIndex = 0;
            this.btnStopSQLServer.Text = "Parar serviços";
            this.btnStopSQLServer.UseVisualStyleBackColor = true;
            this.btnStopSQLServer.Click += new System.EventHandler(this.BtnStopSQLServer_Click);
            // 
            // pnlMachineStopHeader
            // 
            this.pnlMachineStopHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMachineStopHeader.BackColor = System.Drawing.Color.White;
            this.pnlMachineStopHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlMachineStopHeader.Controls.Add(this.lblApplicationName);
            this.pnlMachineStopHeader.Controls.Add(this.btnAbout);
            this.pnlMachineStopHeader.Controls.Add(this.pbDeveloperLogo);
            this.pnlMachineStopHeader.Controls.Add(this.btnMinimize);
            this.pnlMachineStopHeader.Controls.Add(this.btnClose);
            this.pnlMachineStopHeader.Location = new System.Drawing.Point(1, 1);
            this.pnlMachineStopHeader.Name = "pnlMachineStopHeader";
            this.pnlMachineStopHeader.Size = new System.Drawing.Size(645, 41);
            this.pnlMachineStopHeader.TabIndex = 0;
            this.pnlMachineStopHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMachineStopHeader_MouseDown);
            this.pnlMachineStopHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMachineStopHeader_MouseMove);
            this.pnlMachineStopHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlMachineStopHeader_MouseUp);
            // 
            // lblApplicationName
            // 
            this.lblApplicationName.AutoSize = true;
            this.lblApplicationName.CausesValidation = false;
            this.lblApplicationName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApplicationName.Location = new System.Drawing.Point(92, 7);
            this.lblApplicationName.Name = "lblApplicationName";
            this.lblApplicationName.Size = new System.Drawing.Size(217, 25);
            this.lblApplicationName.TabIndex = 2;
            this.lblApplicationName.Text = "DBMS Services Manager";
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAbout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAbout.Location = new System.Drawing.Point(503, 7);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(65, 27);
            this.btnAbout.TabIndex = 1;
            this.btnAbout.Text = "Sobre";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // pbDeveloperLogo
            // 
            this.pbDeveloperLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDeveloperLogo.Enabled = false;
            this.pbDeveloperLogo.Image = global::DBMS_Services_Manager.Properties.Resources.vesoSoftware_Avatar;
            this.pbDeveloperLogo.Location = new System.Drawing.Point(6, -21);
            this.pbDeveloperLogo.Name = "pbDeveloperLogo";
            this.pbDeveloperLogo.Size = new System.Drawing.Size(83, 79);
            this.pbDeveloperLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDeveloperLogo.TabIndex = 2;
            this.pbDeveloperLogo.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMinimize.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimize.Location = new System.Drawing.Point(577, 7);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(28, 27);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.BackColor = System.Drawing.Color.Tomato;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(605, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 27);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tmrServiceStatusVerifier
            // 
            this.tmrServiceStatusVerifier.Tick += new System.EventHandler(this.tmrServiceStatusVerifier_Tick);
            // 
            // btnStopAllServices
            // 
            this.btnStopAllServices.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnStopAllServices.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStopAllServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopAllServices.Image = global::DBMS_Services_Manager.Properties.Resources.Abort;
            this.btnStopAllServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStopAllServices.Location = new System.Drawing.Point(-1, -1);
            this.btnStopAllServices.Name = "btnStopAllServices";
            this.btnStopAllServices.Size = new System.Drawing.Size(204, 37);
            this.btnStopAllServices.TabIndex = 0;
            this.btnStopAllServices.Text = "Parar todos os serviços";
            this.btnStopAllServices.UseVisualStyleBackColor = false;
            this.btnStopAllServices.Click += new System.EventHandler(this.btnStopAllServices_Click);
            // 
            // btnRestartAllServices
            // 
            this.btnRestartAllServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestartAllServices.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRestartAllServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestartAllServices.Image = global::DBMS_Services_Manager.Properties.Resources.Play;
            this.btnRestartAllServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestartAllServices.Location = new System.Drawing.Point(206, -1);
            this.btnRestartAllServices.Name = "btnRestartAllServices";
            this.btnRestartAllServices.Size = new System.Drawing.Size(212, 37);
            this.btnRestartAllServices.TabIndex = 0;
            this.btnRestartAllServices.Text = "Reiniciar todos os serviços";
            this.btnRestartAllServices.UseVisualStyleBackColor = false;
            this.btnRestartAllServices.Click += new System.EventHandler(this.btnRestartAllServices_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Snow;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaShell;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(12, 606);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(622, 26);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlServicesMainController
            // 
            this.pnlServicesMainController.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlServicesMainController.BackColor = System.Drawing.Color.LightGray;
            this.pnlServicesMainController.Controls.Add(this.pnlServicesControllerBorder);
            this.pnlServicesMainController.Location = new System.Drawing.Point(1, 77);
            this.pnlServicesMainController.Name = "pnlServicesMainController";
            this.pnlServicesMainController.Size = new System.Drawing.Size(645, 53);
            this.pnlServicesMainController.TabIndex = 8;
            // 
            // pnlServicesControllerBorder
            // 
            this.pnlServicesControllerBorder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlServicesControllerBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlServicesControllerBorder.Controls.Add(this.btnStopAllServices);
            this.pnlServicesControllerBorder.Controls.Add(this.btnSettings);
            this.pnlServicesControllerBorder.Controls.Add(this.btnRestartAllServices);
            this.pnlServicesControllerBorder.Location = new System.Drawing.Point(11, 8);
            this.pnlServicesControllerBorder.Name = "pnlServicesControllerBorder";
            this.pnlServicesControllerBorder.Size = new System.Drawing.Size(622, 37);
            this.pnlServicesControllerBorder.TabIndex = 4;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSettings.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Image = global::DBMS_Services_Manager.Properties.Resources.pinion;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(421, -1);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(200, 37);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Configurações";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(256, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Comandos rápidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(221, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Gerenciar estado dos serviços";
            // 
            // pnlServiceStatus
            // 
            this.pnlServiceStatus.BackColor = System.Drawing.Color.White;
            this.pnlServiceStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlServiceStatus.Controls.Add(this.lblServiceStatus);
            this.pnlServiceStatus.Location = new System.Drawing.Point(504, 140);
            this.pnlServiceStatus.Name = "pnlServiceStatus";
            this.pnlServiceStatus.Size = new System.Drawing.Size(131, 453);
            this.pnlServiceStatus.TabIndex = 10;
            this.pnlServiceStatus.Visible = false;
            // 
            // lblServiceStatus
            // 
            this.lblServiceStatus.AutoSize = true;
            this.lblServiceStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblServiceStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblServiceStatus.Location = new System.Drawing.Point(45, 10);
            this.lblServiceStatus.Name = "lblServiceStatus";
            this.lblServiceStatus.Size = new System.Drawing.Size(42, 15);
            this.lblServiceStatus.TabIndex = 0;
            this.lblServiceStatus.Text = "Status";
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.LightGray;
            this.panel8.Location = new System.Drawing.Point(1, 599);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(645, 41);
            this.panel8.TabIndex = 11;
            // 
            // lblTimerStatus
            // 
            this.lblTimerStatus.AutoSize = true;
            this.lblTimerStatus.Location = new System.Drawing.Point(560, 55);
            this.lblTimerStatus.Name = "lblTimerStatus";
            this.lblTimerStatus.Size = new System.Drawing.Size(83, 15);
            this.lblTimerStatus.TabIndex = 12;
            this.lblTimerStatus.Text = "TIMER_STATUS";
            this.lblTimerStatus.Visible = false;
            // 
            // btnStopTimer
            // 
            this.btnStopTimer.Location = new System.Drawing.Point(475, 50);
            this.btnStopTimer.Name = "btnStopTimer";
            this.btnStopTimer.Size = new System.Drawing.Size(81, 23);
            this.btnStopTimer.TabIndex = 13;
            this.btnStopTimer.Text = "PARAR";
            this.btnStopTimer.UseVisualStyleBackColor = true;
            this.btnStopTimer.Visible = false;
            this.btnStopTimer.Click += new System.EventHandler(this.btnStopTimer_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(11, 140);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(131, 453);
            this.panel6.TabIndex = 14;
            this.panel6.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(37, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Serviços";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(646, 645);
            this.ControlBox = false;
            this.Controls.Add(this.btnStopTimer);
            this.Controls.Add(this.lblTimerStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlMongoDB);
            this.Controls.Add(this.pnlMachineStopHeader);
            this.Controls.Add(this.pnlServicesMainController);
            this.Controls.Add(this.pnlMariaDB);
            this.Controls.Add(this.pnlPostgreSQL);
            this.Controls.Add(this.pnlMySQL);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.pnlSQLServer);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pnlServiceStatus);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBMS Services Manager";
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMongoDBServiceStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMariaDBServiceStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPostgreSQLServiceStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMySQLServiceStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSQLServerServiceStatus)).EndInit();
            this.pnlMongoDB.ResumeLayout(false);
            this.pnlMongoDB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMariaDB.ResumeLayout(false);
            this.pnlMariaDB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDB04Logo)).EndInit();
            this.pnlPostgreSQL.ResumeLayout(false);
            this.pnlPostgreSQL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDB03Logo)).EndInit();
            this.pnlMySQL.ResumeLayout(false);
            this.pnlMySQL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDB02Logo)).EndInit();
            this.pnlSQLServer.ResumeLayout(false);
            this.pnlSQLServer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDB01Logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlMachineStopHeader.ResumeLayout(false);
            this.pnlMachineStopHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeveloperLogo)).EndInit();
            this.pnlServicesMainController.ResumeLayout(false);
            this.pnlServicesControllerBorder.ResumeLayout(false);
            this.pnlServiceStatus.ResumeLayout(false);
            this.pnlServiceStatus.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lblRunningServicesCounter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTimerStatus;
        private System.Windows.Forms.Button btnStopTimer;
        public System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Label label4;
    }
}

