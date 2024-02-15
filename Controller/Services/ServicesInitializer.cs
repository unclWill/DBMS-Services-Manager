/* Autor: William Silva (https://github.com/unclWill)
 * Data : 14/02/2024
 */

using System;
using System.Windows.Forms;
using DBMS_Services_Manager.View.ServiceStatus;
using MachineStop;

namespace DBMS_Services_Manager.Controller.Services
{
    /// <summary>
    /// Classe responsável pela inicialização dos serviços.
    /// </summary>
    internal class ServicesInitializer
    {
        private FrmPrincipal frmPrincipal;

        public ServicesInitializer(FrmPrincipal frmPrincipal)
        {
            this.frmPrincipal = frmPrincipal;
        }

        public void InitializeServices()
        {
            try
            {
                InitializeSQLServer();
                InitializeMySQL();
                InitializePostgreSQL();
                InitializeMariaDB();
                InitializeMongoDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex}", "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeMySQL()
        {
            // Settings.
            string serviceName = Properties.Settings.Default.MySQL_ServiceName;
            string serviceProcessName = Properties.Settings.Default.MySQL_ProcessName;
            // Service.
            Service mySql = new Service(serviceName, serviceProcessName);
            // View.
            MySQLStatusView mySqlView = new MySQLStatusView();
            // Monitor.
            ServiceMonitor mySqlMonitor = new ServiceMonitor(frmPrincipal);
            mySqlMonitor.ServiceStatus(mySql, mySqlView);
        }

        private void InitializeSQLServer()
        {
            string serviceName = Properties.Settings.Default.SQLServer_ServiceName;
            string serviceProcessName = Properties.Settings.Default.SQLServer_ProcessName;
            Service sqlServer = new Service(serviceName, serviceProcessName);
            SQLServerStatusView sqlServerView = new SQLServerStatusView();
            ServiceMonitor sqlServerMonitor = new ServiceMonitor(frmPrincipal);
            sqlServerMonitor.ServiceStatus(sqlServer, sqlServerView);
        }

        private void InitializePostgreSQL()
        {
            string serviceName = Properties.Settings.Default.PostgreSQL_ServiceName;
            string serviceProcessName = Properties.Settings.Default.PostgreSQL_ProcessName;
            Service postgreSql = new Service(serviceName, serviceProcessName);
            PostgreSQLStatusView postgreSqlView = new PostgreSQLStatusView();
            ServiceMonitor postgreSqlMonitor = new ServiceMonitor(frmPrincipal);
            postgreSqlMonitor.ServiceStatus(postgreSql, postgreSqlView);
        }

        private void InitializeMariaDB()
        {
            string serviceName = Properties.Settings.Default.MariaDB_ServiceName;
            string serviceProcessName = Properties.Settings.Default.MariaDB_ProcessName;
            Service mariaDb = new Service(serviceName, serviceProcessName);
            MariaDBStatusView mariaDbView = new MariaDBStatusView();
            ServiceMonitor mariaDbMonitor = new ServiceMonitor(frmPrincipal);
            mariaDbMonitor.ServiceStatus(mariaDb, mariaDbView);
        }

        private void InitializeMongoDB()
        {
            string serviceName = Properties.Settings.Default.MongoDB_ServiceName;
            string serviceProcessName = Properties.Settings.Default.MongoDB_ProcessName;
            Service mongoDb = new Service(serviceName, serviceProcessName);
            MongoDBStatusView mongoDbView = new MongoDBStatusView();
            ServiceMonitor mongoDbMonitor = new ServiceMonitor(frmPrincipal);
            mongoDbMonitor.ServiceStatus(mongoDb, mongoDbView);
        }
	}
}
