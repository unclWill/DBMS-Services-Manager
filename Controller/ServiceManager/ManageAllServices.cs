/*
 * Author: William Silva (https://github.com/unclWill)
 * Date  : 15/02/2024
 */

using System.ServiceProcess;
using DBMS_Services_Manager.Controller.Services;

namespace DBMS_Services_Manager.Controller.ServiceManager
{
    internal class ManageAllServices
    {
        private string sqlServerProcessName = Properties.Settings.Default.SQLServer_ProcessName;
        private string mySqlProcessName = Properties.Settings.Default.MySQL_ProcessName;
        private string postgreSqlProcessName = Properties.Settings.Default.PostgreSQL_ProcessName;
        private string mariaDbProcessName = Properties.Settings.Default.MariaDB_ProcessName;
        private string mongoDbProcessName = Properties.Settings.Default.MongoDB_ProcessName;

        internal void RestartAllServices()
        {
            Service sqlServer = new Service(sqlServerProcessName);
            if (VerifyPresence(sqlServer))
            {
                sqlServer.StartService();
            }

            Service mySql = new Service(mySqlProcessName);
            if (VerifyPresence(mySql))
            {
                mySql.StartService();
            }

            Service postgreSql = new Service(postgreSqlProcessName);
            if (VerifyPresence(postgreSql))
            {
                postgreSql.StartService();
            }

            Service mariaDb = new Service(mariaDbProcessName);
            if (VerifyPresence(mariaDb))
            {
                mariaDb.StartService();
            }

            Service mongoDb = new Service(mongoDbProcessName);
            if (VerifyPresence(mongoDb))
            {
                mongoDb.StartService();
            }
        }

        internal void StopAllServices()
        {
            Service sqlServer = new Service(sqlServerProcessName);
            if (VerifyPresence(sqlServer) && VerifyServiceRunning(sqlServer))
            {
                sqlServer.StopService();
            }

            Service mySql = new Service(mySqlProcessName);
            if (VerifyPresence(mySql) && VerifyServiceRunning(mySql))
            {
                mySql.StopService();
            }

            Service postgreSql = new Service(postgreSqlProcessName);
            if (VerifyPresence(postgreSql) && VerifyServiceRunning(postgreSql))
            {
                postgreSql.StopService();
            }

            Service mariaDb = new Service(mariaDbProcessName);
            if (VerifyPresence(mariaDb) && VerifyServiceRunning(mariaDb))
            {
                mariaDb.StopService();
            }

            Service mongoDb = new Service(mongoDbProcessName);
            if (VerifyPresence(mongoDb) && VerifyServiceRunning(mongoDb))
            {
                mongoDb.StopService();
            }
        }

        private bool VerifyServiceRunning(Service service)
        {
            ServiceControllerStatus serviceStatus = service.ServiceStatus;
            string status = serviceStatus.ToString();
            return status.Equals("Running");
        }

        private bool VerifyPresence(Service service)
        {
            return service.IsServiceInstalled;
        }
    }
}
