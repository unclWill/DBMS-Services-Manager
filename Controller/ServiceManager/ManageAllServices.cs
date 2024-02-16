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
        private string sqlServerProcessName = Properties.Settings.Default.SQLServer_ServiceName;
        private string mySqlProcessName = Properties.Settings.Default.MySQL_ServiceName;
        private string postgreSqlProcessName = Properties.Settings.Default.PostgreSQL_ServiceName;
        private string mariaDbProcessName = Properties.Settings.Default.MariaDB_ServiceName;
        private string mongoDbProcessName = Properties.Settings.Default.MongoDB_ServiceName;

        internal void RestartAllServices()
        {
            Service sqlServer = new Service(sqlServerProcessName);
            if (CheckIfServiceIsInstalled(sqlServer))
            {
                sqlServer.StartService();
            }

            Service mySql = new Service(mySqlProcessName);
            if (CheckIfServiceIsInstalled(mySql))
            {
                mySql.StartService();
            }

            Service postgreSql = new Service(postgreSqlProcessName);
            if (CheckIfServiceIsInstalled(postgreSql))
            {
                postgreSql.StartService();
            }

            Service mariaDb = new Service(mariaDbProcessName);
            if (CheckIfServiceIsInstalled(mariaDb))
            {
                mariaDb.StartService();
            }

            Service mongoDb = new Service(mongoDbProcessName);
            if (CheckIfServiceIsInstalled(mongoDb))
            {
                mongoDb.StartService();
            }
        }

        internal void StopAllServices()
        {
            Service sqlServer = new Service(sqlServerProcessName);
            if (CheckIfServiceIsInstalled(sqlServer) && CheckIfServiceIsRunning(sqlServer))
            {
                sqlServer.StopService();
            }

            Service mySql = new Service(mySqlProcessName);
            if (CheckIfServiceIsInstalled(mySql) && CheckIfServiceIsRunning(mySql))
            {
                mySql.StopService();
            }

            Service postgreSql = new Service(postgreSqlProcessName);
            if (CheckIfServiceIsInstalled(postgreSql) && CheckIfServiceIsRunning(postgreSql))
            {
                postgreSql.StopService();
            }

            Service mariaDb = new Service(mariaDbProcessName);
            if (CheckIfServiceIsInstalled(mariaDb) && CheckIfServiceIsRunning(mariaDb))
            {
                mariaDb.StopService();
            }

            Service mongoDb = new Service(mongoDbProcessName);
            if (CheckIfServiceIsInstalled(mongoDb) && CheckIfServiceIsRunning(mongoDb))
            {
                mongoDb.StopService();
            }
        }

        private bool CheckIfServiceIsRunning(Service service)
        {
            ServiceControllerStatus serviceStatus = service.ServiceStatus;
            string status = serviceStatus.ToString();
            return status.Equals("Running");
        }

        private bool CheckIfServiceIsInstalled(Service service)
        {
            return service.IsServiceInstalled;
        }
    }
}
