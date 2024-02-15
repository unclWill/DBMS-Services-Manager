/* Autor: William Silva (https://github.com/unclWill)
 * Data : 14/02/2024
 */

using System;
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

        public Service(string serviceProcessName)
        {
            this.serviceProcessName = serviceProcessName;
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

        internal void StartService()
        {
            ServiceController serviceCtrl = new ServiceController(this.ServiceProcessName);
            serviceCtrl.Start();
            var timeout = new TimeSpan(0, 0, 5); // 5seconds
            serviceCtrl.WaitForStatus(ServiceControllerStatus.Running, timeout);
        }

        internal void StopService()
        {
            ServiceController serviceCtrl = new ServiceController(this.ServiceProcessName);
            serviceCtrl.Stop();
            var timeout = new TimeSpan(0, 0, 5);
            serviceCtrl.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
        }
    }
}
