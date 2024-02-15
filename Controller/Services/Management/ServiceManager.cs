using System;
using System.ServiceProcess;

namespace DBMS_Services_Manager.Controller.Services.Management
{
    internal class ServiceManager
    {
        private Service? service;

        public ServiceManager(Service service)
        {
            this.service = service;
        }

        public void StartService()
        {
            ServiceController serviceCtrl = new ServiceController(service.ServiceProcessName);
            serviceCtrl.Start();
            var timeout = new TimeSpan(0, 0, 5); // 5seconds
            serviceCtrl.WaitForStatus(ServiceControllerStatus.Running, timeout);
        }

        public void StopService()
        {
            ServiceController serviceCtrl = new ServiceController(service.ServiceProcessName);
            serviceCtrl.Stop();
            var timeout = new TimeSpan(0, 0, 5);
            serviceCtrl.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
        }
    }
}
