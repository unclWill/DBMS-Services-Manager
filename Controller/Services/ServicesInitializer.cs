/* 
 * Author: William Silva (https://github.com/unclWill)
 * Date  : 14/02/2024
 */

using System;
using DBMS_Services_Manager.View.ServiceStatus;
using MachineStop;

namespace DBMS_Services_Manager.Controller.Services
{
    /// <summary>
    /// Classe responsável pelo instanciamento dos serviços para o ServiceMonitor.
    /// </summary>
    internal class ServicesInitializer
    {
        private string sqlServerServiceName;
        private string mySqlServiceName;
        private string postgreSqlServiceName;
        private string mariaDbServiceName;
        private string mongoDbServiceName;
        private FrmPrincipal frmPrincipal;

        public ServicesInitializer(FrmPrincipal frmPrincipal, string sqlServerServiceName, string mySqlServiceName, string postgreSqlServiceName, string mariaDbServiceName, string mongoDbServiceName)
        {
            this.frmPrincipal = frmPrincipal ?? throw new ArgumentNullException(nameof(frmPrincipal));
            this.sqlServerServiceName = sqlServerServiceName ?? throw new ArgumentNullException(nameof(sqlServerServiceName));
            this.mySqlServiceName = mySqlServiceName ?? throw new ArgumentNullException(nameof(mySqlServiceName));
            this.postgreSqlServiceName = postgreSqlServiceName ?? throw new ArgumentNullException(nameof(postgreSqlServiceName));
            this.mariaDbServiceName = mariaDbServiceName ?? throw new ArgumentNullException(nameof(mariaDbServiceName));
            this.mongoDbServiceName = mongoDbServiceName ?? throw new ArgumentNullException(nameof(mongoDbServiceName));
        }

        /// <summary>
        /// Inicializa o monitoramento de todos os serviços para exibição na barra de status.
        /// </summary>
        internal void InitializeServicesStatusMonitor()
        {
            InitializeService(sqlServerServiceName, new SQLServerStatusView());
            InitializeService(mySqlServiceName, new MySQLStatusView());
            InitializeService(postgreSqlServiceName, new PostgreSQLStatusView());
            InitializeService(mariaDbServiceName, new MariaDBStatusView());
            InitializeService(mongoDbServiceName, new MongoDBStatusView());
        }

        private void InitializeService(string serviceName, IServiceStatusView serviceStatusView)
        {
            Service service = new Service(serviceName);
            ServiceMonitor serviceMonitor = new ServiceMonitor(frmPrincipal);
            serviceMonitor.ServiceStatusMonitor(service, serviceStatusView);
        }
    }
}

