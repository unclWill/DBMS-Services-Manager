/* Autor: William Silva (https://github.com/unclWill)
 * Data : 14/02/2024
 */

using System.Windows.Forms;
using MachineStop;

namespace DBMS_Services_Manager.View
{
    internal class PostgreSQLStatusView : IServiceStatusView
    {
        public void ServiceRunningView(FrmPrincipal frmPrincipal)
        {
            frmPrincipal.txtPostgreSQLServiceStatus.Text = "Em execução";
            frmPrincipal.btnRestartPostgreSQL.Enabled = false;
            frmPrincipal.btnStopPostgreSQL.Enabled = true;
            frmPrincipal.pbPostgreSQLServiceStatus.BackgroundImage = Properties.Resources.OK;
            frmPrincipal.pbPostgreSQLServiceStatus.BackgroundImageLayout = ImageLayout.Center;
        }

        public void ServiceStoppedView(FrmPrincipal frmPrincipal)
        {
            frmPrincipal.txtPostgreSQLServiceStatus.Text = "Parado";
            frmPrincipal.btnRestartPostgreSQL.Enabled = true;
            frmPrincipal.btnStopPostgreSQL.Enabled = false;
            frmPrincipal.pbPostgreSQLServiceStatus.BackgroundImage = Properties.Resources.Abort;
            frmPrincipal.pbPostgreSQLServiceStatus.BackgroundImageLayout = ImageLayout.Center;
        }

        public void ServiceIsNotInstalledView(FrmPrincipal frmPrincipal)
        {
            frmPrincipal.txtPostgreSQLServiceStatus.Text = "Não instalado";
            frmPrincipal.pbPostgreSQLServiceStatus.BackgroundImage = Properties.Resources.Danger;
            frmPrincipal.btnStopPostgreSQL.Enabled = false;
            frmPrincipal.btnRestartPostgreSQL.Enabled = false;
        }
    }
}
