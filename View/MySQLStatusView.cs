/* Autor: William Silva (https://github.com/unclWill)
 * Data : 14/02/2024
 */

using System.Windows.Forms;
using DBMS_Services_Manager.Controller.Services;
using MachineStop;

namespace DBMS_Services_Manager.View
{
    internal class MySQLStatusView : IServiceStatusView
    {
        public void ServiceRunningView(FrmPrincipal frmPrincipal)
        {
            frmPrincipal.txtMySQLServiceStatus.Text = "Em execução";
            frmPrincipal.btnRestartMySQL.Enabled = false;
            frmPrincipal.btnStopMySQL.Enabled = true;
            frmPrincipal.pbMySQLServiceStatus.BackgroundImage = Properties.Resources.OK;
            frmPrincipal.pbMySQLServiceStatus.BackgroundImageLayout = ImageLayout.Center;
        }

        public void ServiceStoppedView(FrmPrincipal frmPrincipal)
        {
            frmPrincipal.txtMySQLServiceStatus.Text = "Parado";
            frmPrincipal.btnRestartMySQL.Enabled = true;
            frmPrincipal.btnStopMySQL.Enabled = false;
            frmPrincipal.pbMySQLServiceStatus.BackgroundImage = Properties.Resources.Abort;
            frmPrincipal.pbMySQLServiceStatus.BackgroundImageLayout = ImageLayout.Center;
        }

        public void ServiceIsNotInstalledView(FrmPrincipal frmPrincipal)
        {
            frmPrincipal.txtMySQLServiceStatus.Text = "Não instalado";
            frmPrincipal.pbMySQLServiceStatus.BackgroundImage = Properties.Resources.Danger;
            frmPrincipal.btnStopMySQL.Enabled = false;
            frmPrincipal.btnRestartMySQL.Enabled = false;
        }
    }
}
