/*
 * Author: William Silva (https://github.com/unclWill)
 * Date  : 16/02/2024
 */

using System;
using System.Collections.Generic;
using System.ServiceProcess;
using DBMS_Services_Manager.Controller.Services;
using DBMS_Services_Manager.Globals;
using DBMS_Services_Manager.Properties;
using MachineStop.Forms;

namespace DBMS_Services_Manager.Controller.ServiceManager
{
    internal class AllServicesStatusManager
    {
        private FrmConfigs frmConfigs = new FrmConfigs();

        private Dictionary<string, string> serviceNames = new Dictionary<string, string>
        {
            { ServiceName.SQLServer, "SQL Server"},
            { ServiceName.MySQL, "MySQL" },
            { ServiceName.PostgreSQL, "PostgreSQL" },
            { ServiceName.MariaDB, "MariaDB" },
            { ServiceName.MongoDB, "MongoDB" }
        };

        private void ManageService(string serviceName, ServiceControllerStatus status, Action<string> serviceAction)
        {
            Service service = new Service(serviceName);
            if (service.IsServiceInstalled && service.ServiceStatus.Equals(status))
            {
                serviceAction(serviceName);
            }
        }

        internal void RestartAllServices()
        {
            foreach (var service in serviceNames)
            {
                ManageService(service.Key, ServiceControllerStatus.Stopped, Service.StartService);
            }
        }

        internal void StopAllServices()
        {
            foreach (var service in serviceNames)
            {
                if (Settings.Default.StartupMode.Equals(ServiceStartupType.Manual))
                {
                    Service.StartupService(service.Key, ServiceStartMode.Manual);
                }
                else if (Settings.Default.StartupMode.Equals(ServiceStartupType.Automatico))
                {
                    Service.StartupService(service.Key, ServiceStartMode.Automatic);
                }

                ManageService(service.Key, ServiceControllerStatus.Running, Service.StopService);
            }
        }
    }
}