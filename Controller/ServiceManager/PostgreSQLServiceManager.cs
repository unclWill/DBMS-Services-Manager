/* 
 * Author: William Silva (https://github.com/unclWill)
 * Date  : 15/02/2024
 */

using DBMS_Services_Manager.Controller.Services;

namespace DBMS_Services_Manager.Controller.ServiceManager
{
    internal class PostgreSQLServiceManager
    {
        public static void StartService()
        {
            string serviceName = Properties.Settings.Default.PostgreSQL_ServiceName;
            Service postgreSql = new Service(serviceName);
            postgreSql.StartService();
        }

        public static void StopService()
        {
            string serviceName = Properties.Settings.Default.PostgreSQL_ServiceName;
            Service postgreSql = new Service(serviceName);
            postgreSql.StopService();
        }
    }
}
