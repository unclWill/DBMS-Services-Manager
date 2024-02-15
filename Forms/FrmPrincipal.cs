using System;
using System.Windows.Forms;
using System.ServiceProcess;
using MachineStop.Forms;
using System.Drawing;
using DBMS_Services_Manager.Controller.ExecutionPolicies;
using DBMS_Services_Manager.Controller.Services;
using DBMS_Services_Manager.View;
using DBMS_Services_Manager.Controller.Services.Management;

namespace MachineStop
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            // Códigos adicionados pelo desenvolvedor:
            WindowsElevationInfo();

            this.DoubleBuffered = true;
            //Monitor de serviços
            ServiceMonitor serviceMonitor = new ServiceMonitor(this);
            serviceMonitor.StartServiceMonitor();
        }

        #region PROPRIEDADES DOS CONTROLES QUE INTERAGEM COM OS SERVIÇOS.
        // Propriedades
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

        public Button BtnStartMySQL
        {
            get => BtnStartMySQL;
            set => BtnStartMySQL = value;
        }
        #endregion

        //Instanciação do formulário de configurações
        frmConfigs formConfigs = new frmConfigs();

        #region Controles alternativos da janela
        ///
        /// Tornando o painel clicável e fazendo a janela ser arrastável
        ///
        private bool mouseDown;
        private Point lastLocation;

        private void pnlMachineStopHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void pnlMachineStopHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void pnlMachineStopHeader_MouseMove(object sender, MouseEventArgs e)
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
            //if (MessageBox.Show("Deseja encerrar a aplicação agora?", "Encerrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            Application.Exit();
            //}
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
        //
        #endregion

        /// 
        /// Tratando dos serviços do SQLServer
        ///
        //Iniciando o serviço
        private void StartSQLServer()
        {

        }

        //Parando o serviço
        private void StopSQLServer()
        {
            ServiceController SQLServerMainService = new ServiceController(formConfigs.txtSQLServerProcessName.Text);

            SQLServerMainService.Stop();
            var mainServiceTimeout = new TimeSpan(0, 0, 9); //9seconds
            SQLServerMainService.WaitForStatus(ServiceControllerStatus.Stopped, mainServiceTimeout);
        }

        private void BtnStopSQLServer_Click(object sender, EventArgs e)
        {
            try
            {
                StopSQLServer();
            }
            catch (Exception ex)
            {
                const string message = "Considere a possibilidade de o nome do serviço no Windows ser diferente do nome definido na janela de configurações";
                MessageBox.Show(message, ex.Message);
            }
        }

        private void btnRestartSQLServer_Click(object sender, EventArgs e)
        {
            try
            {
                StartSQLServer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// 
        /// Tratando dos serviços do MYSQL
        ///
        //Iniciando o serviço
        private void StartMySQL()
        {
            string serviceName = DBMS_Services_Manager.Properties.Settings.Default.MySQL_ServiceName;
            string serviceProcessName = DBMS_Services_Manager.Properties.Settings.Default.MySQL_ProcessName;
            Service mySql = new Service(serviceName, serviceProcessName);
            ServiceManager mySqlSvc = new ServiceManager(mySql);
            mySqlSvc.StartService();
        }

        //Parando o serviço
        private void StopMySQL()
        {
            string serviceName = DBMS_Services_Manager.Properties.Settings.Default.MySQL_ServiceName;
            string serviceProcessName = DBMS_Services_Manager.Properties.Settings.Default.MySQL_ProcessName;
            Service mySql = new Service(serviceName, serviceProcessName);
            ServiceManager mySqlSvc = new ServiceManager(mySql);
            mySqlSvc.StopService();
        }

        private void btnStopMySQL_Click(object sender, EventArgs e)
        {
            try
            {
                StopMySQL();
            }
            catch (Exception ex)
            {
                const string message = "Considere a possibilidade de o nome do serviço no Windows ser diferente do nome definido na janela de configurações";
                MessageBox.Show(message, ex.Message);
            }
        }

        private void btnRestartMySQL_Click(object sender, EventArgs e)
        {
            try
            {
                StartMySQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        ///
        /// Tratando dos serviços do POSTGRESQL
        ///
        //Iniciando o serviço
        private void StartPostgreSQL()
        {

        }

        //Parando o serviço
        private void StopPostgreSQL()
        {

        }

        private void btnStopPostgreSQL_Click(object sender, EventArgs e)
        {
            try
            {
                StopPostgreSQL();
            }
            catch (Exception ex)
            {
                const string message = "Considere a possibilidade de o nome do serviço no Windows ser diferente do nome definido na janela de configurações";
                MessageBox.Show(message, ex.Message);
            }
        }

        private void btnRestartPostgreSQL_Click(object sender, EventArgs e)
        {
            try
            {
                StartPostgreSQL();
            }
            catch (Exception ex)
            {
                const string message = "Considere a possibilidade de o nome do serviço no Windows ser diferente do nome definido na janela de configurações";
                MessageBox.Show(message, ex.Message);
            }
        }

        ///
        /// Tratando dos serviços do MariaDB
        ///
        //Inciando o serviço
        private void StartMariaDB()
        {

        }

        //Parando o serviço
        private void RestartMariaDB()
        {

        }

        private void btnStopMariaDB_Click(object sender, EventArgs e)
        {

        }

        private void btnRestartMariaDB_Click(object sender, EventArgs e)
        {

        }

        ///
        /// Tratando dos serviços do MongoDB
        ///
        //Inciando o serviço
        private void StartMongoDB()
        {

        }

        //Parando o serviço
        private void RestartMongoDB()
        {

        }

        private void btnStopMongoDB_Click(object sender, EventArgs e)
        {

        }

        private void btnRestartMongoDB_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            formConfigs.ShowDialog();
        }

        private void btnStopAllServices_Click(object sender, EventArgs e)
        {
            try
            {
                StopSQLServer();
                StopPostgreSQL();
                StopMySQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show("[MENSAGEM DE ERRO]" + ex.Message +
                                "\n\n[MENSAGEM DE AVISO]\nVerifique se o serviço já não está parado!");
            }
        }

        private void btnRestartAllServices_Click(object sender, EventArgs e)
        {
            try
            {
                StartSQLServer();
                StartPostgreSQL();
                StartMySQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show("[MENSAGEM DE ERRO]\n" + ex.Message +
                                "\n\n[MENSAGEM DE AVISO]\nVerifique se o serviço já não está inicializado!");
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(//"DBMS Services Manager - Versão: " + ProductVersion + "\n" +
                "DBMS Services Manager - Versão: 1.0.14.02.24-alpha\n" +
                "Gerenciador de Serviços de Bancos de Dados para Windows.\n\n" +
                "Desenvolvido por: William Silva\n" +
                "Repositórios: github.com/unclWill\n" +
                "Contato: william.silva@viannasempre.com.br \n\n" +
                "© 2022-2024 VESO Software. Direitos reservados.", "Sobre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Verificando se o programa está sendo executado como Administrador
        private void WindowsElevationInfo()
        {
            ElevationChecker elevationChecker = new ElevationChecker();

            if (elevationChecker.IsElevated)
            {
                this.Text = "DBMS Services Manager [Admin]";
            }
            else
            {
                this.Text = "DBMS Services Manager [Non-Admin]";
            }
        }

        public void tmrServiceStatusVerifier_Tick(object sender, EventArgs e)
        {
            ServiceMonitor serviceMonitor = new ServiceMonitor(this);
            serviceMonitor.MonitorTimerEventTrigger();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
