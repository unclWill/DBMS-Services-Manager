/* Autor: William Silva (https://github.com/unclWill)
 * Data : 14/02/2024
 */

using System.Windows.Forms;
using MachineStop;

namespace DBMS_Services_Manager.View
{
    internal class SQLServerStatusView : IServiceStatusView
    {
        public void ServiceRunningView(FrmPrincipal frmPrincipal)
        {
            frmPrincipal.txtSQLServerServiceStatus.Text = "Em execução";
            frmPrincipal.btnRestartSQLServer.Enabled = false;
            frmPrincipal.btnStopSQLServer.Enabled = true;
            frmPrincipal.pbSQLServerServiceStatus.BackgroundImage = Properties.Resources.OK;
            frmPrincipal.pbSQLServerServiceStatus.BackgroundImageLayout = ImageLayout.Center;
        }

        public void ServiceStoppedView(FrmPrincipal frmPrincipal)
        {
            frmPrincipal.txtSQLServerServiceStatus.Text = "Parado";
            frmPrincipal.btnRestartSQLServer.Enabled = true;
            frmPrincipal.btnStopSQLServer.Enabled = false;
            frmPrincipal.pbSQLServerServiceStatus.BackgroundImage = Properties.Resources.Abort;
            frmPrincipal.pbSQLServerServiceStatus.BackgroundImageLayout = ImageLayout.Center;
        }

        public void ServiceIsNotInstalledView(FrmPrincipal frmPrincipal)
        {
            frmPrincipal.txtSQLServerServiceStatus.Text = "Não instalado";
            frmPrincipal.pbSQLServerServiceStatus.BackgroundImage = Properties.Resources.Danger;
            frmPrincipal.btnStopSQLServer.Enabled = false;
            frmPrincipal.btnRestartSQLServer.Enabled = false;
        }
    }
}
