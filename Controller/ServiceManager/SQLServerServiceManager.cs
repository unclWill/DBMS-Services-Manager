/* 
 * Author: William Silva (https://github.com/unclWill)
 * Date  : 15/02/2024
 */

using DBMS_Services_Manager.Controller.Services;

namespace DBMS_Services_Manager.Controller.ServiceManager
{
    internal class SQLServerServiceManager
    {
        public static void StartService()
        {
            string serviceName = Properties.Settings.Default.SQLServer_ServiceName;
            Service sqlServer = new Service(serviceName);
            sqlServer.StartService();
        }

        public static void StopService()
        {
            string serviceName = Properties.Settings.Default.SQLServer_ServiceName;
            Service sqlServer = new Service(serviceName);
            sqlServer.StopService();
        }
    }
}
