/* 
 * Author: William Silva (https://github.com/unclWill)
 * Date  : 15/02/2024
 */

using DBMS_Services_Manager.Controller.Services;

namespace DBMS_Services_Manager.Controller.ServiceManager
{
    internal class MongoDBServiceManager
    {
        public static void StartService()
        {
            string serviceName = Properties.Settings.Default.MongoDB_ServiceName;
            Service mongoDb = new Service(serviceName);
            mongoDb.StartService();
        }

        public static void StopService()
        {
            string serviceName = Properties.Settings.Default.MongoDB_ServiceName;
            Service mongoDb = new Service(serviceName);
            mongoDb.StopService();
        }
    }
}
