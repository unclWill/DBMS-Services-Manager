

using DBMS_Services_Manager.Controller.Services;

namespace DBMS_Services_Manager.Controller.ServiceManager
{
    internal static class ServiceStatusManager
    { 
        public static void StartService(string serviceName)
        {
            Service.StartService(serviceName);
        }

        public static void StopService(string serviceName)
        {
            Service.StopService(serviceName);
        }
    }
}
