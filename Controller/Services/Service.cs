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
        private string? serviceName;
        private string? serviceProcessName;

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
            get => serviceName!;
            set => serviceName = value;
        }

        public string ServiceProcessName
        {
            get => serviceProcessName!;
            set => serviceProcessName = value;
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
            try
            {
                ServiceController serviceController = new ServiceController(this.ServiceProcessName);
                serviceController.Start();
                var timeout = new TimeSpan(0, 0, 5); // 5 seconds.
                serviceController.WaitForStatus(ServiceControllerStatus.Running, timeout);
            }
            catch (Exception ex)
            {
                string elevationMsg = CheckExecutionPrivileges.RequireElevationMessage();
                const string message = "Ocorreu um erro ao tentar iniciar o serviço";
                MessageBox.Show($"[Erro] {ex.Message}\n\n[Aviso] {elevationMsg}", message);
            }
        }

        internal void StopService()
        {
            try
            {
                ServiceController serviceController = new ServiceController(this.ServiceProcessName);
                serviceController.Stop();
                var timeout = new TimeSpan(0, 0, 5);
                serviceController.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
            }
            catch (Exception ex)
            {
                string elevationMsg = CheckExecutionPrivileges.RequireElevationMessage();
                const string message = "Ocorreu um erro ao tentar parar o serviço";
                MessageBox.Show($"[Erro] {ex.Message}\n\n[Aviso] {elevationMsg}", message);
            }
        }
    }
}