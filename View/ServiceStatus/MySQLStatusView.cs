/* Autor: William Silva (https://github.com/unclWill)
 * Data : 14/02/2024
 */

using System.Windows.Forms;
using MachineStop;

namespace DBMS_Services_Manager.View.ServiceStatus
{
    internal class MySQLStatusView : IServiceStatusView
    {
        public void ServiceRunningView(FrmPrincipal frmPrincipal)
        {
            frmPrincipal.TxtMySQLServiceStatus.Text = "Em execução";
            frmPrincipal.BtnRestartMySQL.Enabled = false;
            frmPrincipal.BtnStopMySQL.Enabled = true;
            frmPrincipal.PbMySQLServiceStatus.BackgroundImage = Properties.Resources.OK;
            frmPrincipal.PbMySQLServiceStatus.BackgroundImageLayout = ImageLayout.Center;
        }

        public void ServiceStoppedView(FrmPrincipal frmPrincipal)
        {
            frmPrincipal.TxtMySQLServiceStatus.Text = "Parado";
            frmPrincipal.BtnRestartMySQL.Enabled = true;
            frmPrincipal.BtnStopMySQL.Enabled = false;
            frmPrincipal.PbMySQLServiceStatus.BackgroundImage = Properties.Resources.Abort;
            frmPrincipal.PbMySQLServiceStatus.BackgroundImageLayout = ImageLayout.Center;
        }

        public void ServiceIsNotInstalledView(FrmPrincipal frmPrincipal)
        {
            frmPrincipal.TxtMySQLServiceStatus.Text = "Não instalado";
            frmPrincipal.PbMySQLServiceStatus.BackgroundImage = Properties.Resources.Danger;
            frmPrincipal.BtnRestartMySQL.Enabled = false;
            frmPrincipal.BtnStopMySQL.Enabled = false;
        }
    }
}
