/* 
 * Author: William Silva (https://github.com/unclWill)
 * Date  : 15/02/2024
 */

using System;
using System.Windows.Forms;
using MachineStop.Forms;
using System.Drawing;
using DBMS_Services_Manager.Controller.ExecutionPolicies;
using DBMS_Services_Manager.Controller.Services;
using DBMS_Services_Manager.Controller.ServiceManager;
using DBMS_Services_Manager.Forms;
using DBMS_Services_Manager.Globals;
using System.Configuration;
using DBMS_Services_Manager.Properties;

namespace MachineStop
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            CheckAndCreateConfig();
        }

        #region Controls properties.
        // SQLServer
        public PictureBox PbSQLServerServiceStatus
        {
            get => pbSQLServerServiceStatus;
            set => pbSQLServerServiceStatus = value;
        }

        public TextBox TxtSQLServerServiceStatus
        {
            get => txtSQLServerServiceStatus;
            set => txtSQLServerServiceStatus = value;
        }

        public Button BtnRestartSQLServer
        {
            get => btnRestartSQLServer;
            set => btnRestartSQLServer = value;
        }

        public Button BtnStopSQLServer
        {
            get => btnStopSQLServer;
            set => btnStopSQLServer = value;
        }

        // MySQL
        public PictureBox PbMySQLServiceStatus
        {
            get => pbMySQLServiceStatus;
            set => pbMySQLServiceStatus = value;
        }

        public TextBox TxtMySQLServiceStatus
        {
            get => txtMySQLServiceStatus;
            set => txtMySQLServiceStatus = value;
        }

        public Button BtnRestartMySQL
        {
            get => btnRestartMySQL;
            set => btnRestartMySQL = value;
        }

        public Button BtnStopMySQL
        {
            get => btnStopMySQL;
            set => btnStopMySQL = value;
        }

        // PostgreSQL
        public PictureBox PbPostgreSQLServiceStatus
        {
            get => pbPostgreSQLServiceStatus;
            set => pbPostgreSQLServiceStatus = value;
        }

        public TextBox TxtPostgreSQLServiceStatus
        {
            get => txtPostgreSQLServiceStatus;
            set => txtPostgreSQLServiceStatus = value;
        }

        public Button BtnRestartPostgreSQL
        {
            get => btnRestartPostgreSQL;
            set => btnRestartPostgreSQL = value;
        }

        public Button BtnStopPostgreSQL
        {
            get => btnStopPostgreSQL;
            set => btnStopPostgreSQL = value;
        }

        // MariaDB
        public PictureBox PbMariaDBServiceStatus
        {
            get => pbMariaDBServiceStatus;
            set => pbMariaDBServiceStatus = value;
        }

        public TextBox TxtMariaDBServiceStatus
        {
            get => txtMariaDBServiceStatus;
            set => txtMariaDBServiceStatus = value;
        }

        public Button BtnRestartMariaDB
        {
            get => btnRestartMariaDB;
            set => btnRestartMariaDB = value;
        }

        public Button BtnStopMariaDB
        {
            get => btnStopMariaDB;
            set => btnStopMariaDB = value;
        }

        // MongoDB
        public PictureBox PbMongoDBServiceStatus
        {
            get => pbMongoDBServiceStatus;
            set => pbMongoDBServiceStatus = value;
        }

        public TextBox TxtMongoDBServiceStatus
        {
            get => txtMongoDBServiceStatus;
            set => txtMongoDBServiceStatus = value;
        }

        public Button BtnRestartMongoDB
        {
            get => btnRestartMongoDB;
            set => btnRestartMongoDB = value;
        }

        public Button BtnStopMongoDB
        {
            get => btnStopMongoDB;
            set => btnStopMongoDB = value;
        }

        // All Services
        public Button BtnStopAllServices
        {
            get => btnStopAllServices;
            set => btnStopAllServices = value;
        }

        public Button BtnRestartAllServices
        {
            get => btnRestartAllServices;
            set => btnRestartAllServices = value;
        }
        #endregion

        #region Customized window controls.
        ///
        /// Tornando o painel clicável e fazendo a janela ser arrastável.
        ///
        private bool mouseDown;
        private Point lastLocation;

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        //Fechar a janela
        private void Exit()
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        //Minimizar a janela
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Services Management Buttons
        private void BtnStopSQLServer_Click(object sender, EventArgs e)
        {
            ServiceStatusManager.StopService(ServiceName.SQLServer);
        }

        private void btnRestartSQLServer_Click(object sender, EventArgs e)
        {
            ServiceStatusManager.StartService(ServiceName.SQLServer);
        }

        private void btnStopMySQL_Click(object sender, EventArgs e)
        {
            ServiceStatusManager.StopService(ServiceName.MySQL);
        }

        private void btnRestartMySQL_Click(object sender, EventArgs e)
        {
            ServiceStatusManager.StartService(ServiceName.MySQL);
        }

        private void btnStopPostgreSQL_Click(object sender, EventArgs e)
        {
            ServiceStatusManager.StopService(ServiceName.PostgreSQL);
        }

        private void btnRestartPostgreSQL_Click(object sender, EventArgs e)
        {
            ServiceStatusManager.StartService(ServiceName.PostgreSQL);
        }

        private void btnStopMariaDB_Click(object sender, EventArgs e)
        {
            ServiceStatusManager.StopService(ServiceName.MariaDB);
        }

        private void btnRestartMariaDB_Click(object sender, EventArgs e)
        {
            ServiceStatusManager.StartService(ServiceName.MariaDB);
        }

        private void btnStopMongoDB_Click(object sender, EventArgs e)
        {
            ServiceStatusManager.StopService(ServiceName.MongoDB);
        }

        private void btnRestartMongoDB_Click(object sender, EventArgs e)
        {
            ServiceStatusManager.StartService(ServiceName.MongoDB);
        }

        private void btnStopAllServices_Click(object sender, EventArgs e)
        {
            AllServicesStatusManager manageAllServices = new AllServicesStatusManager();
            manageAllServices.StopAllServices();
        }

        private void btnRestartAllServices_Click(object sender, EventArgs e)
        {
            AllServicesStatusManager manageAllServices = new AllServicesStatusManager();
            manageAllServices.RestartAllServices();
        }
        #endregion

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmConfigs frmConfigs = new FrmConfigs();
            frmConfigs.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            FrmAbout aboutBox = new FrmAbout();
            aboutBox.ShowDialog();
        }

        private void CheckControlsAboutExecutionPrivileges()
        {
            ElevationChecker elevationChk = new ElevationChecker();
            if (!elevationChk.IsElevated)
            {
                BtnRestartAllServices.Enabled = false;
                BtnStopAllServices.Enabled = false;
                MessageBox.Show("É necessário executar o programa como Administrador para poder realizar operações.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CheckControlsAboutExecutionPrivileges();
            ElevationChecker elevationChk = new ElevationChecker();
            this.Text = elevationChk.WindowsElevationInfo();

            ServiceMonitor serviceMonitor = new ServiceMonitor(this);

            

            serviceMonitor.StartServiceMonitor();
        }

        internal void tmrServiceStatusVerifier_Tick(object sender, EventArgs e)
        {
            ServiceMonitor serviceMonitor = new ServiceMonitor(this);
            serviceMonitor.MonitorTimerEventTrigger();
        }

        private void CheckAndCreateConfig()
        {
            bool firstRun = Settings.Default.FirstRun;
            if (firstRun)
            {
                CreateDefaultConfig();
            }
            else
            {
                LoadServiceConfigs();
            }
        }

        private void CreateDefaultConfig()
        {
            Settings.Default.SQLServer_ServiceName = "MSSQL$SQLEXPRESS";
            Settings.Default.SQLServer_DisplayName = "SQL Server";
            //
            Settings.Default.MySQL_ServiceName = "MySQL80";
            Settings.Default.MySQL_DisplayName = "MySQL";
            //
            Settings.Default.PostgreSQL_ServiceName = "postgresql-x64-16";
            Settings.Default.PostgreSQL_DisplayName = "PostgreSQL";
            //
            Settings.Default.MariaDB_ServiceName = "mariadb";
            Settings.Default.MariaDB_DisplayName = "MariaDB";
            //
            Settings.Default.MongoDB_ServiceName = "mongodb";
            Settings.Default.MongoDB_DisplayName = "MongoDB";
            //
            Settings.Default.FirstRun = false;
            //
            Settings.Default.Save();
            MessageBox.Show("As configurações padrão foram criadas!\nPara alterá-las acesse a aba de Configurações.", "[Aviso] Primeira execução", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadServiceConfigs()
        {
            FrmConfigs configs = new FrmConfigs();
            configs.LoadConfigs();
        }
    }
}
