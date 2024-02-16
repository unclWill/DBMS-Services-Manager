/* 
 * Author: William Silva (https://github.com/unclWill)
 * Date  : 14/02/2024
 */

using System;
using System.ServiceProcess;
using DBMS_Services_Manager.Controller.ExecutionPolicies;
using System.Windows.Forms;

namespace DBMS_Services_Manager.Controller.Services
{
    internal class Service
    {
        private string displayName;
        private string serviceName;

        public Service(string displayName, string serviceName)
        {
            DisplayName = displayName;
            ServiceName = serviceName;
        }

        public Service(string serviceName)
        {
            this.serviceName = serviceName;
        }

        public Service() { }

        public string DisplayName
        {
            get => displayName;
            set => displayName = value;
        }

        public string ServiceName
        {
            get => serviceName!;
            set => serviceName = value;
        }

        public bool IsServiceInstalled
        {
            get
            {
                ServiceController[] services = ServiceController.GetServices();

                foreach (ServiceController service in services)
                {
                    if (service.ServiceName == serviceName)
                        return true;
                }
                return false;
            }
        }

        public ServiceControllerStatus ServiceStatus
        {
            get
            {
                ServiceController serviceController = new ServiceController(this.serviceName);
                return serviceController.Status;
            }
        }

        internal void StartService()
        {
            try
            {
                ServiceController serviceController = new ServiceController(this.ServiceName);
                serviceController.Start();
                var timeout = new TimeSpan(0, 0, 5); // 5 seconds.
                serviceController.WaitForStatus(ServiceControllerStatus.Running, timeout);
            }
            catch (Exception ex)
            {
                string elevationMsg = CheckExecutionPrivileges.RequireElevationMessage();
                const string message = "Ocorreu um erro ao tentar iniciar o serviço";
                MessageBox.Show($"[Erro] {ex.Message}\n\n[Aviso] {elevationMsg}", message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void StopService()
        {
            try
            {
                ServiceController serviceController = new ServiceController(this.ServiceName);
                serviceController.Stop();
                var timeout = new TimeSpan(0, 0, 5);
                serviceController.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
            }
            catch (Exception ex)
            {
                string elevationMsg = CheckExecutionPrivileges.RequireElevationMessage();
                const string message = "Ocorreu um erro ao tentar parar o serviço";
                MessageBox.Show($"[Erro] {ex.Message}\n\n[Aviso] {elevationMsg}", message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}