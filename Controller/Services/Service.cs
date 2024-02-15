/* Autor: William Silva (https://github.com/unclWill)
 * Data : 14/02/2024
 */

using System.ServiceProcess;

namespace DBMS_Services_Manager.Controller.Services
{
    internal class Service
    {
        private string _serviceName;
        private string serviceProcessName;

        public Service(string serviceName, string serviceProcessName)
        {
            ServiceName = serviceName;
            ServiceProcessName = serviceProcessName;
        }

        public Service() { }

        public string ServiceName
        {
            get { return _serviceName; }
            set { _serviceName = value; }
        }

        public string ServiceProcessName
        {
            get { return serviceProcessName; }
            set { serviceProcessName = value; }
        }

        public bool IsServiceInstalled
        {
            get
            {
                ServiceController[] services = ServiceController.GetServices();

                foreach (ServiceController service in services)
                {
                    if (service.ServiceName == serviceProcessName)
                        return true;
                }
                return false;
            }
        }
    }
}
