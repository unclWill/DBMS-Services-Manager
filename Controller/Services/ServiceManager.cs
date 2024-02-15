using System;
using System.ServiceProcess;

namespace DBMS_Services_Manager.Controller.Services
{
    internal class ServiceManager
    {
        private Service _serviceMgr;

        public Service ServiceMagr
        {
            get { return _serviceMgr; }
            set { _serviceMgr = value; }
        }

        public void StartService(Service service)
        {
            ServiceController serviceCtrl = new ServiceController(service.ServiceProcessName);
            serviceCtrl.Start();
            var timeout = new TimeSpan(0, 0, 5); // 5seconds
            serviceCtrl.WaitForStatus(ServiceControllerStatus.Running, timeout);
        }

        public void StopService(Service service)
        {
            ServiceController serviceCtrl = new ServiceController(service.ServiceProcessName);
            serviceCtrl.Stop();
            var timeout = new TimeSpan(0, 0, 5);
            serviceCtrl.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
        }
    }
}
