/* 
 * Author: William Silva (https://github.com/unclWill)
 * Date  : 14/02/2024
 */

using MachineStop;

namespace DBMS_Services_Manager.View.ServiceStatus
{
    internal interface IServiceStatusView
    {
        public void ServiceRunningView(FrmMain frmPrincipal);
        public void ServiceStoppedView(FrmMain frmPrincipal);
        public void ServiceIsNotInstalledView(FrmMain frmPrincipal);
    }
}
