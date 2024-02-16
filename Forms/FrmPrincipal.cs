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

namespace MachineStop
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        #region Propriedades dos controles.
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
        #endregion

        #region Controles alternativos da janela
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

        internal void tmrServiceStatusVerifier_Tick(object sender, EventArgs e)
        {
            ServiceMonitor serviceMonitor = new ServiceMonitor(this);
            serviceMonitor.MonitorTimerEventTrigger();
        }

        private void BtnStopSQLServer_Click(object sender, EventArgs e)
        {
            SQLServerServiceManager.StopService();
        }

        private void btnRestartSQLServer_Click(object sender, EventArgs e)
        {
            SQLServerServiceManager.StartService();
        }

        private void btnStopMySQL_Click(object sender, EventArgs e)
        {
            MySQLServiceManager.StopService();
        }

        private void btnRestartMySQL_Click(object sender, EventArgs e)
        {
            MySQLServiceManager.StartService();
        }

        private void btnStopPostgreSQL_Click(object sender, EventArgs e)
        {
            PostgreSQLServiceManager.StopService();
        }

        private void btnRestartPostgreSQL_Click(object sender, EventArgs e)
        {
            PostgreSQLServiceManager.StartService();
        }

        private void btnStopMariaDB_Click(object sender, EventArgs e)
        {
            MariaDBServiceManager.StopService();
        }

        private void btnRestartMariaDB_Click(object sender, EventArgs e)
        {
            MariaDBServiceManager.StartService();
        }

        private void btnStopMongoDB_Click(object sender, EventArgs e)
        {
            MongoDBServiceManager.StopService();
        }

        private void btnRestartMongoDB_Click(object sender, EventArgs e)
        {
            MongoDBServiceManager.StartService();
        }

        private void btnStopAllServices_Click(object sender, EventArgs e)
        {
            ManageAllServices manageAllServices = new ManageAllServices();
            manageAllServices.StopAllServices();
        }

        private void btnRestartAllServices_Click(object sender, EventArgs e)
        {
            ManageAllServices manageAllServices = new ManageAllServices();
            manageAllServices.RestartAllServices();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmConfigs frmConfigs = new frmConfigs();
            frmConfigs.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            FrmAbout aboutBox = new FrmAbout();
            aboutBox.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            ElevationChecker elevationChk = new ElevationChecker();
            this.Text = elevationChk.WindowsElevationInfo();
            ServiceMonitor serviceMonitor = new ServiceMonitor(this);
            serviceMonitor.StartServiceMonitor();
        }
    }
}
