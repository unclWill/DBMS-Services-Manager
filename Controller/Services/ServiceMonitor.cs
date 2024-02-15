/* 
 * Author: William Silva (https://github.com/unclWill)
 * Date  : 14/02/2024
 */

using DBMS_Services_Manager.View.ServiceStatus;
using MachineStop;
using System;
using System.ServiceProcess;
using System.Windows.Forms;

namespace DBMS_Services_Manager.Controller.Services
{
    /// <summary>
    /// Classe responsável por realizar o monitoramento do estado dos serviços.
    /// </summary>
    internal class ServiceMonitor
    {
        private FrmPrincipal frmPrincipal;

        public ServiceMonitor(FrmPrincipal frmPrincipal)
        {
            this.frmPrincipal = frmPrincipal;
        }

        internal void ServiceStatus(Service service, IServiceStatusView serviceStatusView)
        {
            ServiceController serviceProcess = new ServiceController(service.ServiceProcessName);

            if (service.IsServiceInstalled)
            {
                if (serviceProcess.Status == ServiceControllerStatus.Running)
                {
                    serviceStatusView.ServiceRunningView(frmPrincipal);
                }
                else if (serviceProcess.Status == ServiceControllerStatus.Stopped)
                {
                    serviceStatusView.ServiceStoppedView(frmPrincipal);
                }
            }
            else
            {
                serviceStatusView.ServiceIsNotInstalledView(frmPrincipal);
            }
        }

        //Timer que acompanha em tempo real o estado de execução dos serviços.
        internal void StartServiceMonitor()
        {
            frmPrincipal.tmrServiceStatusVerifier.Interval = 300;
            frmPrincipal.tmrServiceStatusVerifier.Tick += new EventHandler(frmPrincipal.tmrServiceStatusVerifier_Tick!);
            frmPrincipal.tmrServiceStatusVerifier.Enabled = true;
        }

        private void StopServiceMonitor()
        {
            frmPrincipal.tmrServiceStatusVerifier.Interval = 3600;
            frmPrincipal.tmrServiceStatusVerifier.Tick += new EventHandler(frmPrincipal.tmrServiceStatusVerifier_Tick!);
            frmPrincipal.tmrServiceStatusVerifier.Enabled = false;
        }

        internal void MonitorTimerEventTrigger()
        {
            ServicesInitializer svcInit = new ServicesInitializer(frmPrincipal);

            try
            {
                svcInit.InitializeServicesStatusMonitor();
            }
            catch (Exception ex)
            {
                const string message = "Ocorreu um erro";
                MessageBox.Show($"[Erro] {ex.Message}\n\n[Aviso] Ocorreu um erro", message);
            }
        }
    }
}
