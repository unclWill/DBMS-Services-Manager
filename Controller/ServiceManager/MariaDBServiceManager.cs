/* 
 * Author: William Silva (https://github.com/unclWill)
 * Date  : 15/02/2024
 */

using DBMS_Services_Manager.Controller.Services;

namespace DBMS_Services_Manager.Controller.ServiceManager
{
    internal class MariaDBServiceManager
    {
        public static void StartService()
        {
            string serviceName = Properties.Settings.Default.MariaDB_ServiceName;
            Service mariaDb = new Service(serviceName);
            mariaDb.StartService();
        }

        public static void StopService()
        {
            string serviceName = Properties.Settings.Default.MariaDB_ServiceName;
            Service mariaDb = new Service(serviceName);
            mariaDb.StopService();
        }
    }
}
