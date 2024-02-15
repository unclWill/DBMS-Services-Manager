/* Autor: William Silva (https://github.com/unclWill)
 * Data : 14/02/2024
 */

using MachineStop;

namespace DBMS_Services_Manager.View.ServiceStatus
{
    internal interface IServiceStatusView
    {
        public void ServiceRunningView(FrmPrincipal frmPrincipal);
        public void ServiceStoppedView(FrmPrincipal frmPrincipal);
        public void ServiceIsNotInstalledView(FrmPrincipal frmPrincipal);
    }
}
