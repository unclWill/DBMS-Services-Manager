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
            string serviceProcessName = Properties.Settings.Default.SQLServer_ProcessName;
            Service sqlServer = new Service(serviceProcessName);
            sqlServer.StartService();
        }

        public static void StopService()
        {
            string serviceProcessName = Properties.Settings.Default.SQLServer_ProcessName;
            Service sqlServer = new Service(serviceProcessName);
            sqlServer.StopService();
        }
    }
}
