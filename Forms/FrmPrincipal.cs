using System;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Security.Principal;
using MachineStop.Forms;
using System.Drawing;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;

namespace MachineStop
{
    public partial class FrmPrincipal : Form
    {
        #region Construtor
        public FrmPrincipal()
        {
            InitializeComponent();
            //Códigos adicionados pelo desenvolvedor:
            WindowsRoleVerification();
            this.DoubleBuffered = true;
            //Monitor de serviços
            StartTimerServiceMonitor();
            IsTimerRunning();
        }
        #endregion

        //Instanciação da classe ServicesMonitor. PROBLEMÁTICA
        //ServicesMonitor servicesMonitor = new ServicesMonitor();

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

        //Código temporário
        public static void UnderDevelopment()
        {
            MessageBox.Show("Esta funcionalidade não está disponivel nesta versão do aplicativo.", "Recurso em desenvolvimento", MessageBoxButtons.OK);
        }

        //Verificando se o programa está sendo executado como Administrador
        public static bool IsAdministrator()
        {
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal userElevationChecker = new WindowsPrincipal(identity);
                return userElevationChecker.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }

        //Define o texto que aparece no Botão IsAdmin
        private void WindowsRoleVerification()
        {
            if (IsAdministrator() == true)
            {
                this.Text = "DBMS Services Manager [Admin]";
            }
            else
            {
                this.Text = "DBMS Services Manager [Non-Admin]";
            }
        }

        //Listando os serviços existentes no sistema para saber quais estão instalados.
        public static bool IsServiceInstalled(string serviceName)
        {
            ServiceController[] services = ServiceController.GetServices();

            foreach (ServiceController service in services)
            {
                if (service.ServiceName == serviceName)
                    return true;
            }
            return false;
        }

        //Timer que faz a verificação em tempo real da execução dos serviços.
        public void StartTimerServiceMonitor()
        {
            //Task.Run(() =>
            //{
            tmrServiceStatusVerifier.Interval = 300;
            tmrServiceStatusVerifier.Tick += new EventHandler(tmrServiceStatusVerifier_Tick!);
            tmrServiceStatusVerifier.Enabled = true;
            //});
        }

        public void StopTimerServiceMonitor()
        {
            tmrServiceStatusVerifier.Interval = 3600;
            tmrServiceStatusVerifier.Tick += new EventHandler(tmrServiceStatusVerifier_Tick!);
            tmrServiceStatusVerifier.Enabled = false;
        }

        private void btnStopTimer_Click(object sender, EventArgs e)
        {
            IsTimerRunning();
            if (tmrServiceStatusVerifier.Enabled == true)
            {
                StopTimerServiceMonitor();
                btnStopTimer.Text = "INICIAR";
            }
            else if (tmrServiceStatusVerifier.Enabled == false)
            {
                StartTimerServiceMonitor();
                btnStopTimer.Text = "PARAR";
            }
            IsTimerRunning();
        }

        public void IsTimerRunning()
        {
            if (tmrServiceStatusVerifier.Enabled == true)
            {
                lblTimerStatus.Text = "Monitorando...";
            }
            else
            {
                lblTimerStatus.Text = "Monitor parado.";
            }
        }

        private void tmrServiceStatusVerifier_Tick(object sender, EventArgs e)
        {
            try
            {
                SQLServerServiceMonitor();
                MySQLServiceMonitor();
                PostgreSQLServiceMonitor();
                MariaDBServiceMonitor();
                MongoDBServiceMonitor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SQLServerServiceMonitor()
        {
            if (IsServiceInstalled(formConfigs.txtSQLServerMainService.Text) == true) ///| IsServiceInstalled(formConfigs.txtSQLServerSecondaryService.Text) == true | IsServiceInstalled(formConfigs.txtSQLServerExtraService.Text) == true)
            {
                ServiceController SQLServerMainService = new ServiceController(formConfigs.txtSQLServerMainService.Text);
                ///ServiceController SQLServerSecondaryService = new ServiceController(formConfigs.txtSQLServerSecondaryService.Text);
                ///ServiceController SQLServerExtraService = new ServiceController(formConfigs.txtSQLServerExtraService.Text);

                {
                    if (SQLServerMainService.Status == ServiceControllerStatus.Running) /// & SQLServerSecondaryService.Status == ServiceControllerStatus.Running & SQLServerExtraService.Status == ServiceControllerStatus.Stopped)
                    {
                        lblRunningServicesCounter.Text = "TODOS RODANDO";
                        btnRestartSQLServer.Enabled = false;
                        btnStopSQLServer.Enabled = true;
                        txtSQLServerServiceStatus.Text = "Em execução";
                        pbSQLServerServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.OK;
                        pbSQLServerServiceStatus.BackgroundImageLayout = ImageLayout.Center;
                    }
                    else if (SQLServerMainService.Status == ServiceControllerStatus.Stopped) ///& SQLServerSecondaryService.Status == ServiceControllerStatus.Stopped & SQLServerExtraService.Status == ServiceControllerStatus.Stopped)
                    {
                        lblRunningServicesCounter.Text = "TODOS PARADOS";
                        btnRestartSQLServer.Enabled = true;
                        btnStopSQLServer.Enabled = false;
                        txtSQLServerServiceStatus.Text = "Parado";
                        pbSQLServerServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.Abort;
                        pbSQLServerServiceStatus.BackgroundImageLayout = ImageLayout.Center;
                    }
                }
            }
            else
            {
                txtSQLServerServiceStatus.Text = "Não instalado";
                pbSQLServerServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.Danger;
                btnStopSQLServer.Enabled = false;
                btnRestartSQLServer.Enabled = false;
            }
        }

        public void MySQLServiceMonitor()
        {
            if (IsServiceInstalled(formConfigs.txtMySQLMainService.Text) == true)
            {

                ServiceController MySQL = new ServiceController(formConfigs.txtMySQLMainService.Text);

                if (MySQL.Status == ServiceControllerStatus.Running)
                {

                    btnRestartMySQL.Enabled = false;
                    btnStopMySQL.Enabled = true;
                    txtMySQLServiceStatus.Text = "Em execução";
                    pbMySQLServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.OK;
                    pbMySQLServiceStatus.BackgroundImageLayout = ImageLayout.Center;
                }
                else if (MySQL.Status == ServiceControllerStatus.Stopped)
                {
                    btnRestartMySQL.Enabled = true;
                    btnStopMySQL.Enabled = false;
                    txtMySQLServiceStatus.Text = "Parado";
                    pbMySQLServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.Abort;
                    pbMySQLServiceStatus.BackgroundImageLayout = ImageLayout.Center;
                }
            }
            else
            {
                txtMySQLServiceStatus.Text = "Não instalado";
                pbMySQLServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.Danger;
                btnStopMySQL.Enabled = false;
                btnRestartMySQL.Enabled = false;
            }
        }

        public void PostgreSQLServiceMonitor()
        {
            if (IsServiceInstalled(formConfigs.txtPostgreSQLMainService.Text) == true)
            {
                ServiceController PostgreSQL = new ServiceController(formConfigs.txtPostgreSQLMainService.Text);

                if (PostgreSQL.Status == ServiceControllerStatus.Running)
                {
                    btnRestartPostgreSQL.Enabled = false;
                    btnStopPostgreSQL.Enabled = true;
                    txtPostgreSQLServiceStatus.Text = "Em execução";
                    pbPostgreSQLServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.OK;
                    pbPostgreSQLServiceStatus.BackgroundImageLayout = ImageLayout.Center;
                }
                else if (PostgreSQL.Status == ServiceControllerStatus.Stopped)
                {
                    btnRestartPostgreSQL.Enabled = true;
                    btnStopPostgreSQL.Enabled = false;
                    txtPostgreSQLServiceStatus.Text = "Parado";
                    pbPostgreSQLServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.Abort;
                    pbPostgreSQLServiceStatus.BackgroundImageLayout = ImageLayout.Center;
                }
            }
            else
            {
                txtPostgreSQLServiceStatus.Text = "Não instalado";
                pbPostgreSQLServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.Danger;
                btnStopPostgreSQL.Enabled = false;
                btnRestartPostgreSQL.Enabled = false;
            }
        }

        public void MariaDBServiceMonitor()
        {
            if (IsServiceInstalled(formConfigs.txtMariaDBMainService.Text) == true)
            {
                ServiceController MariaDB = new ServiceController(formConfigs.txtMariaDBMainService.Text);

                if (MariaDB.Status == ServiceControllerStatus.Running)
                {
                    btnRestartMariaDB.Enabled = false;
                    btnStopMariaDB.Enabled = true;
                    txtMariaDBServiceStatus.Text = "Em execução";
                    pbMariaDBServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.OK;
                    pbMariaDBServiceStatus.BackgroundImageLayout = ImageLayout.Center;
                }
                else if (MariaDB.Status == ServiceControllerStatus.Stopped)
                {
                    btnRestartMariaDB.Enabled = true;
                    btnStopMariaDB.Enabled = false;
                    txtMariaDBServiceStatus.Text = "Parado";
                    pbMariaDBServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.Abort;
                    pbMariaDBServiceStatus.BackgroundImageLayout = ImageLayout.Center;
                }
            }
            else
            {
                txtMariaDBServiceStatus.Text = "Não instalado";
                pbMariaDBServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.Danger;
                btnStopMariaDB.Enabled = false;
                btnRestartMariaDB.Enabled = false;
            }
        }

        public void MongoDBServiceMonitor()
        {
            if (IsServiceInstalled(formConfigs.txtMongoDBMainService.Text) == true)
            {
                ServiceController MongoDB = new ServiceController(formConfigs.txtMongoDBMainService.Text);

                if (MongoDB.Status == ServiceControllerStatus.Running)
                {
                    btnRestartMongoDB.Enabled = false;
                    btnStopMongoDB.Enabled = true;
                    txtMongoDBServiceStatus.Text = "Em execução";
                    pbMongoDBServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.OK;
                    pbMongoDBServiceStatus.BackgroundImageLayout = ImageLayout.Center;
                }
                else if (MongoDB.Status == ServiceControllerStatus.Stopped)
                {
                    btnRestartMongoDB.Enabled = true;
                    btnStopMongoDB.Enabled = false;
                    txtMongoDBServiceStatus.Text = "Parado";
                    pbMongoDBServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.Abort;
                    pbMongoDBServiceStatus.BackgroundImageLayout = ImageLayout.Center;
                }
            }
            else
            {
                txtMongoDBServiceStatus.Text = "Não instalado";
                pbMongoDBServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.Danger;
                btnStopMongoDB.Enabled = false;
                btnRestartMongoDB.Enabled = false;
            }
        }

        /// 
        /// Tratando dos serviços do SQLServer
        ///
        //Iniciando o serviço
        private void StartSQLServer()
        {
            ServiceController SQLServerMainService = new ServiceController(formConfigs.txtSQLServerMainService.Text);
            ///ServiceController SQLServerSecondaryService = new ServiceController(formConfigs.txtSQLServerSecondaryService.Text);
            ///ServiceController SQLServerExtraService = new ServiceController(formConfigs.txtSQLServerExtraService.Text);

            SQLServerMainService.Start();
            var mainServiceTimeout = new TimeSpan(0, 0, 9); // 9seconds
            SQLServerMainService.WaitForStatus(ServiceControllerStatus.Running, mainServiceTimeout);

            /*
            SQLServerSecondaryService.Start();
            var secondaryServiceTimeout = new TimeSpan(0, 0, 9);
            SQLServerSecondaryService.WaitForStatus(ServiceControllerStatus.Running, secondaryServiceTimeout);

            SQLServerExtraService.Start();
            var extraServiceTimeout = new TimeSpan(0, 0, 9);
            SQLServerExtraService.WaitForStatus(ServiceControllerStatus.Running, extraServiceTimeout);
            */
        }

        //Parando o serviço
        private void StopSQLServer()
        {
            ServiceController SQLServerMainService = new ServiceController(formConfigs.txtSQLServerMainService.Text);
            ///ServiceController SQLServerSecondaryService = new ServiceController(formConfigs.txtSQLServerSecondaryService.Text);
            ///ServiceController SQLServerExtraService = new ServiceController(formConfigs.txtSQLServerExtraService.Text);

            SQLServerMainService.Stop();
            var mainServiceTimeout = new TimeSpan(0, 0, 9); //9seconds
            SQLServerMainService.WaitForStatus(ServiceControllerStatus.Stopped, mainServiceTimeout); //Verifica se o serviço já está parado, dentro de 9 segundos.
            // O Serviço do SQLServer gera erro se o Timeout estiver definido com um valor abaixo de 9 segundos.

            /*
            SQLServerSecondaryService.Stop();
            var secondaryServiceTimeout = new TimeSpan(0, 0, 9); //9seconds
            SQLServerSecondaryService.WaitForStatus(ServiceControllerStatus.Stopped, secondaryServiceTimeout);

            SQLServerExtraService.Stop();
            var extraServiceTimeout = new TimeSpan(0, 0, 9); //9seconds
            SQLServerExtraService.WaitForStatus(ServiceControllerStatus.Stopped, extraServiceTimeout);
            */
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
            string MYSQL_MAIN_SERVICE = formConfigs.txtMySQLMainService.Text;
            string MYSQL_SECONDARY_SERVICE = formConfigs.txtMySQLSecondaryService.Text;
            string MYSQL_EXTRA_SERVICE = formConfigs.txtMySQLExtraService.Text;

            ServiceController mySQLService = new ServiceController(MYSQL_MAIN_SERVICE);
            mySQLService.Start();
            var timeout = new TimeSpan(0, 0, 5); // 5seconds
            mySQLService.WaitForStatus(ServiceControllerStatus.Running, timeout);
        }

        //Parando o serviço
        private void StopMySQL()
        {
            string MYSQL_MAIN_SERVICE = formConfigs.txtMySQLMainService.Text;
            string MYSQL_SECONDARY_SERVICE = formConfigs.txtMySQLSecondaryService.Text;
            string MYSQL_EXTRA_SERVICE = formConfigs.txtMySQLExtraService.Text;

            ServiceController mySQLService = new ServiceController(MYSQL_MAIN_SERVICE);
            mySQLService.Stop();
            var timeout = new TimeSpan(0, 0, 5); //conta 5 segundos até dar timeout
            mySQLService.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
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
            string POSTGRESQL_MAIN_SERVICE = formConfigs.txtPostgreSQLMainService.Text;
            string POSTGRESQL_SECONDARY_SERVICE = formConfigs.txtPostgreSQLSecondaryService.Text;
            string POSTGRESQL_EXTRA_SERVICE = formConfigs.txtPostgreSQLExtraService.Text;

            ServiceController postgresqlService = new ServiceController(POSTGRESQL_MAIN_SERVICE);
            postgresqlService.Start();
            //var timeout = new TimeSpan(0, 0, 5); //conta 5 segundos até dar timeout
            //postgresqlService.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
        }

        //Parando o serviço
        private void StopPostgreSQL()
        {
            string POSTGRESQL_MAIN_SERVICE = formConfigs.txtPostgreSQLMainService.Text;
            string POSTGRESQL_SECONDARY_SERVICE = formConfigs.txtPostgreSQLSecondaryService.Text;
            string POSTGRESQL_EXTRA_SERVICE = formConfigs.txtPostgreSQLExtraService.Text;

            ServiceController postgresqlService = new ServiceController(POSTGRESQL_MAIN_SERVICE.Trim());
            postgresqlService.Stop();
            var timeout = new TimeSpan(0, 0, 5); //conta 5 segundos até dar timeout
            postgresqlService.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
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
            UnderDevelopment();
        }

        private void btnRestartMariaDB_Click(object sender, EventArgs e)
        {
            UnderDevelopment();
        }

        ///
        /// Tratando dos serviços do MongoDB
        ///
        //Inciando o serviço
        private void StartMongoDB()
        {
            UnderDevelopment();
        }

        //Parando o serviço
        private void RestartMongoDB()
        {
            UnderDevelopment();
        }

        private void btnStopMongoDB_Click(object sender, EventArgs e)
        {
            UnderDevelopment();
        }

        private void btnRestartMongoDB_Click(object sender, EventArgs e)
        {
            UnderDevelopment();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(//"DBMS Services Manager - Versão: " + ProductVersion + "\n" +
                "DBMS Services Manager - Versão: 1.0.07.01.23-alpha\n" +
                "Gerenciador de Serviços de Bancos de Dados para Windows.\n\n" +
                "Desenvolvido por: William B. Silva\n" +
                "Repositórios: github.com/unclWill\n" +
                "Contato: william.silva@viannasempre.com.br \n\n" +
                "© 2022 VESO Software. Direitos reservados.", "Sobre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            formConfigs.ShowDialog();
            StopTimerServiceMonitor();
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
    }
}
