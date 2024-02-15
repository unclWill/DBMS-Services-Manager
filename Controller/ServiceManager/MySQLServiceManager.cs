/* Autor: William Silva (https://github.com/unclWill)
 * Data : 15/02/2024
 */

using DBMS_Services_Manager.Controller.Services;

namespace DBMS_Services_Manager.Controller.ServiceManager
{
    internal class MySQLServiceManager
    {
        public static void StartService()
        {
            string serviceProcessName = Properties.Settings.Default.MySQL_ProcessName;
            Service mySql = new Service(serviceProcessName);
            mySql.StartService();
        }

        public static void StopService()
        {
            string serviceProcessName = Properties.Settings.Default.MySQL_ProcessName;
            Service mySql = new Service(serviceProcessName);
            mySql.StopService();
        }
    }
}
