using MachineStop;
using MachineStop.Forms;
using System.ServiceProcess;
using System.Windows.Forms;

namespace DBMS_Services_Manager.Classes
{
    public class ServicesMonitor
    {
        //Instanciação do frmConfigs.
        frmConfigs formConfigs = new frmConfigs();
        FrmPrincipal formPrincipal = new FrmPrincipal();

        //
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

        public void SQLServerServiceMonitor()
        {
            if (IsServiceInstalled(formConfigs.txtSQLServerMainService.Text) == true)
            {
                ServiceController SQLServer = new ServiceController(formConfigs.txtSQLServerMainService.Text);

                if (SQLServer.Status == ServiceControllerStatus.Running)
                {
                    formPrincipal.btnRestartSQLServer.Enabled = false;
                    formPrincipal.btnStopSQLServer.Enabled = true;
                    formPrincipal.txtSQLServerServiceStatus.Text = "Em execução";
                    formPrincipal.pbSQLServerServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.OK;
                    formPrincipal.pbSQLServerServiceStatus.BackgroundImageLayout = ImageLayout.Center;
                }
                else if (SQLServer.Status == ServiceControllerStatus.Stopped)
                {
                    formPrincipal.btnRestartSQLServer.Enabled = true;
                    formPrincipal.btnStopSQLServer.Enabled = false;
                    formPrincipal.txtSQLServerServiceStatus.Text = "Parado";
                    formPrincipal.pbSQLServerServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.Abort;
                    formPrincipal.pbSQLServerServiceStatus.BackgroundImageLayout = ImageLayout.Center;
                }
            }
            else
            {
                formPrincipal.txtSQLServerServiceStatus.Text = "Não instalado";
                formPrincipal.pbSQLServerServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.Danger;
                formPrincipal.btnStopSQLServer.Enabled = false;
                formPrincipal.btnRestartSQLServer.Enabled = false;
            }
        }

        public void MySQLServiceMonitor()
        {
            if (IsServiceInstalled(formConfigs.txtMySQLMainService.Text) == true)
            {

                ServiceController MySQL = new ServiceController(formConfigs.txtMySQLMainService.Text);

                if (MySQL.Status == ServiceControllerStatus.Running)
                {

                    formPrincipal.btnRestartMySQL.Enabled = false;
                    formPrincipal.btnStopMySQL.Enabled = true;
                    formPrincipal.txtMySQLServiceStatus.Text = "Em execução";
                    formPrincipal.pbMySQLServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.OK;
                    formPrincipal.pbMySQLServiceStatus.BackgroundImageLayout = ImageLayout.Center;
                }
                else if (MySQL.Status == ServiceControllerStatus.Stopped)
                {
                    formPrincipal.btnRestartMySQL.Enabled = true;
                    formPrincipal.btnStopMySQL.Enabled = false;
                    formPrincipal.txtMySQLServiceStatus.Text = "Parado";
                    formPrincipal.pbMySQLServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.Abort;
                    formPrincipal.pbMySQLServiceStatus.BackgroundImageLayout = ImageLayout.Center;
                }
            }
            else
            {
                formPrincipal.txtMySQLServiceStatus.Text = "Não instalado";
                formPrincipal.pbMySQLServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.Danger;
                formPrincipal.btnStopMySQL.Enabled = false;
                formPrincipal.btnRestartMySQL.Enabled = false;
            }
        }

        public void PostgreSQLServiceMonitor()
        {
            if (IsServiceInstalled(formConfigs.txtPostgreSQLMainService.Text) == true)
            {
                ServiceController PostgreSQL = new ServiceController(formConfigs.txtPostgreSQLMainService.Text);

                if (PostgreSQL.Status == ServiceControllerStatus.Running)
                {
                    formPrincipal.btnRestartPostgreSQL.Enabled = false;
                    formPrincipal.btnStopPostgreSQL.Enabled = true;
                    formPrincipal.txtPostgreSQLServiceStatus.Text = "Em execução";
                    formPrincipal.pbPostgreSQLServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.OK;
                    formPrincipal.pbPostgreSQLServiceStatus.BackgroundImageLayout = ImageLayout.Center;
                }
                else if (PostgreSQL.Status == ServiceControllerStatus.Stopped)
                {
                    formPrincipal.btnRestartPostgreSQL.Enabled = true;
                    formPrincipal.btnStopPostgreSQL.Enabled = false;
                    formPrincipal.txtPostgreSQLServiceStatus.Text = "Parado";
                    formPrincipal.pbPostgreSQLServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.Abort;
                    formPrincipal.pbPostgreSQLServiceStatus.BackgroundImageLayout = ImageLayout.Center;
                }
            }
            else
            {
                formPrincipal.txtPostgreSQLServiceStatus.Text = "Não instalado";
                formPrincipal.pbPostgreSQLServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.Danger;
                formPrincipal.btnStopPostgreSQL.Enabled = false;
                formPrincipal.btnRestartPostgreSQL.Enabled = false;
            }
        }

        public void MariaDBServiceMonitor()
        {
            if (IsServiceInstalled(formConfigs.txtMariaDBMainService.Text) == true)
            {
                ServiceController MariaDB = new ServiceController(formConfigs.txtMariaDBMainService.Text);

                if (MariaDB.Status == ServiceControllerStatus.Running)
                {
                    formPrincipal.btnRestartMariaDB.Enabled = false;
                    formPrincipal.btnStopMariaDB.Enabled = true;
                    formPrincipal.txtMariaDBServiceStatus.Text = "Em execução";
                    formPrincipal.pbMariaDBServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.OK;
                    formPrincipal.pbMariaDBServiceStatus.BackgroundImageLayout = ImageLayout.Center;
                }
                else if (MariaDB.Status == ServiceControllerStatus.Stopped)
                {
                    formPrincipal.btnRestartMariaDB.Enabled = true;
                    formPrincipal.btnStopMariaDB.Enabled = false;
                    formPrincipal.txtMariaDBServiceStatus.Text = "Parado";
                    formPrincipal.pbMariaDBServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.Abort;
                    formPrincipal.pbMariaDBServiceStatus.BackgroundImageLayout = ImageLayout.Center;
                }
            }
            else
            {
                formPrincipal.txtMariaDBServiceStatus.Text = "Não instalado";
                formPrincipal.pbMariaDBServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.Danger;
                formPrincipal.btnStopMariaDB.Enabled = false;
                formPrincipal.btnRestartMariaDB.Enabled = false;
            }
        }

        public void MongoDBServiceMonitor()
        {
            if (IsServiceInstalled(formConfigs.txtMongoDBMainService.Text) == true)
            {
                ServiceController MongoDB = new ServiceController(formConfigs.txtMongoDBMainService.Text);

                if (MongoDB.Status == ServiceControllerStatus.Running)
                {
                    formPrincipal.btnRestartMongoDB.Enabled = false;
                    formPrincipal.btnStopMongoDB.Enabled = true;
                    formPrincipal.txtMongoDBServiceStatus.Text = "Em execução";
                    formPrincipal.pbMongoDBServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.OK;
                    formPrincipal.pbMongoDBServiceStatus.BackgroundImageLayout = ImageLayout.Center;
                }
                else if (MongoDB.Status == ServiceControllerStatus.Stopped)
                {
                    formPrincipal.btnRestartMongoDB.Enabled = true;
                    formPrincipal.btnStopMongoDB.Enabled = false;
                    formPrincipal.txtMongoDBServiceStatus.Text = "Parado";
                    formPrincipal.pbMongoDBServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.Abort;
                    formPrincipal.pbMongoDBServiceStatus.BackgroundImageLayout = ImageLayout.Center;
                }
            }
            else
            {
                formPrincipal.txtMongoDBServiceStatus.Text = "Não instalado";
                formPrincipal.pbMongoDBServiceStatus.BackgroundImage = DBMS_Services_Manager.Properties.Resources.Danger;
                formPrincipal.btnStopMongoDB.Enabled = false;
                formPrincipal.btnRestartMongoDB.Enabled = false;
            }
        }

        /*public void StartTimerServiceMonitor()
        {
            formPrincipal.tmrServiceStatusVerifier.Interval = 300;
            formPrincipal.tmrServiceStatusVerifier.Tick += new EventHandler(formPrincipal.tmrServiceStatusVerifier_Tick);
            formPrincipal.tmrServiceStatusVerifier.Enabled = true;
        }*/
    }
}
