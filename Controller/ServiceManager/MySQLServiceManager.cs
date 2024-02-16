/* 
 * Author: William Silva (https://github.com/unclWill)
 * Date  : 15/02/2024
 */

using DBMS_Services_Manager.Controller.Services;

namespace DBMS_Services_Manager.Controller.ServiceManager
{
    internal class MySQLServiceManager
    {
        public static void StartService()
        {
            string serviceName = Properties.Settings.Default.MySQL_ServiceName;
            Service mySql = new Service(serviceName);
            mySql.StartService();
        }

        public static void StopService()
        {
            string serviceName = Properties.Settings.Default.MySQL_ServiceName;
            Service mySql = new Service(serviceName);
            mySql.StopService();
        }
    }
}
