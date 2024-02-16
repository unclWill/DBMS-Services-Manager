/* 
 * Author: William Silva (https://github.com/unclWill)
 * Date  : 14/02/2024
 */

using System;
using System.Windows.Forms;
using DBMS_Services_Manager.View.ServiceStatus;
using MachineStop;

namespace DBMS_Services_Manager.Controller.Services
{
    /// <summary>
    /// Classe responsável pelo instanciamento dos serviços para o ServiceMonitor.
    /// </summary>
    internal class ServicesInitializer
    {
        private string sqlServerProcessName = Properties.Settings.Default.SQLServer_ProcessName;
        private string mySqlProcessName = Properties.Settings.Default.MySQL_ProcessName;
        private string postgreSqlProcessName = Properties.Settings.Default.PostgreSQL_ProcessName;
        private string mariaDbProcessName = Properties.Settings.Default.MariaDB_ProcessName;
        private string mongoDbProcessName = Properties.Settings.Default.MongoDB_ProcessName;

        private FrmPrincipal frmPrincipal;

        public ServicesInitializer(FrmPrincipal frmPrincipal)
        {
            this.frmPrincipal = frmPrincipal;
        }

        internal void InitializeServicesStatusMonitor()
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
                MessageBox.Show($"[Erro] {ex}", "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeSQLServer()
        {
            Service sqlServer = new Service(sqlServerProcessName);
            SQLServerStatusView sqlServerView = new SQLServerStatusView();
            ServiceMonitor sqlServerMonitor = new ServiceMonitor(frmPrincipal);
            sqlServerMonitor.ServiceStatusMonitor(sqlServer, sqlServerView);
        }

        private void InitializeMySQL()
        {
            // Service.
            Service mySql = new Service(mySqlProcessName);
            // View.
            MySQLStatusView mySqlView = new MySQLStatusView();
            // Monitor.
            ServiceMonitor mySqlMonitor = new ServiceMonitor(frmPrincipal);
            mySqlMonitor.ServiceStatusMonitor(mySql, mySqlView);
        }

        private void InitializePostgreSQL()
        {
            Service postgreSql = new Service(postgreSqlProcessName);
            PostgreSQLStatusView postgreSqlView = new PostgreSQLStatusView();
            ServiceMonitor postgreSqlMonitor = new ServiceMonitor(frmPrincipal);
            postgreSqlMonitor.ServiceStatusMonitor(postgreSql, postgreSqlView);
        }

        private void InitializeMariaDB()
        {
            Service mariaDb = new Service(mariaDbProcessName);
            MariaDBStatusView mariaDbView = new MariaDBStatusView();
            ServiceMonitor mariaDbMonitor = new ServiceMonitor(frmPrincipal);
            mariaDbMonitor.ServiceStatusMonitor(mariaDb, mariaDbView);
        }

        private void InitializeMongoDB()
        {
            Service mongoDb = new Service(mongoDbProcessName);
            MongoDBStatusView mongoDbView = new MongoDBStatusView();
            ServiceMonitor mongoDbMonitor = new ServiceMonitor(frmPrincipal);
            mongoDbMonitor.ServiceStatusMonitor(mongoDb, mongoDbView);
        }
	}
}
