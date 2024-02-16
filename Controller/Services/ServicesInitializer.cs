/* 
 * Author: William Silva (https://github.com/unclWill)
 * Date  : 14/02/2024
 */

using DBMS_Services_Manager.View.ServiceStatus;
using MachineStop;

namespace DBMS_Services_Manager.Controller.Services
{
    /// <summary>
    /// Classe responsável pelo instanciamento dos serviços para o ServiceMonitor.
    /// </summary>
    internal class ServicesInitializer
    {
        private string sqlServerServiceName = Properties.Settings.Default.SQLServer_ServiceName;
        private string mySqlServiceName = Properties.Settings.Default.MySQL_ServiceName;
        private string postgreSqlServiceName = Properties.Settings.Default.PostgreSQL_ServiceName;
        private string mariaDbServiceName = Properties.Settings.Default.MariaDB_ServiceName;
        private string mongoDbServiceName = Properties.Settings.Default.MongoDB_ServiceName;

        private FrmPrincipal frmPrincipal;

        public ServicesInitializer(FrmPrincipal frmPrincipal)
        {
            this.frmPrincipal = frmPrincipal;
        }

        internal void InitializeServicesStatusMonitor()
        {
            InitializeSQLServer();
            InitializeMySQL();
            InitializePostgreSQL();
            InitializeMariaDB();
            InitializeMongoDB();
        }

        private void InitializeSQLServer()
        {
                Service sqlServer = new Service(sqlServerServiceName);
                SQLServerStatusView sqlServerView = new SQLServerStatusView();
                ServiceMonitor sqlServerMonitor = new ServiceMonitor(frmPrincipal);
                sqlServerMonitor.ServiceStatusMonitor(sqlServer, sqlServerView);
        }

        private void InitializeMySQL()
        {
            // Service.
            Service mySql = new Service(mySqlServiceName);
            // View.
            MySQLStatusView mySqlView = new MySQLStatusView();
            // Monitor.
            ServiceMonitor mySqlMonitor = new ServiceMonitor(frmPrincipal);
            mySqlMonitor.ServiceStatusMonitor(mySql, mySqlView);
        }

        private void InitializePostgreSQL()
        {
            Service postgreSql = new Service(postgreSqlServiceName);
            PostgreSQLStatusView postgreSqlView = new PostgreSQLStatusView();
            ServiceMonitor postgreSqlMonitor = new ServiceMonitor(frmPrincipal);
            postgreSqlMonitor.ServiceStatusMonitor(postgreSql, postgreSqlView);
        }

        private void InitializeMariaDB()
        {
            Service mariaDb = new Service(mariaDbServiceName);
            MariaDBStatusView mariaDbView = new MariaDBStatusView();
            ServiceMonitor mariaDbMonitor = new ServiceMonitor(frmPrincipal);
            mariaDbMonitor.ServiceStatusMonitor(mariaDb, mariaDbView);
        }

        private void InitializeMongoDB()
        {
            Service mongoDb = new Service(mongoDbServiceName);
            MongoDBStatusView mongoDbView = new MongoDBStatusView();
            ServiceMonitor mongoDbMonitor = new ServiceMonitor(frmPrincipal);
            mongoDbMonitor.ServiceStatusMonitor(mongoDb, mongoDbView);
        }
	}
}
