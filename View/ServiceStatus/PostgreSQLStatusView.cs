/* Autor: William Silva (https://github.com/unclWill)
 * Data : 14/02/2024
 */

using System.Windows.Forms;
using MachineStop;

namespace DBMS_Services_Manager.View.ServiceStatus
{
    internal class PostgreSQLStatusView : IServiceStatusView
    {
        public void ServiceRunningView(FrmPrincipal frmPrincipal)
        {
            frmPrincipal.TxtPostgreSQLServiceStatus.Text = "Em execução";
            frmPrincipal.BtnRestartPostgreSQL.Enabled = false;
            frmPrincipal.BtnStopPostgreSQL.Enabled = true;
            frmPrincipal.PbPostgreSQLServiceStatus.BackgroundImage = Properties.Resources.OK;
            frmPrincipal.PbPostgreSQLServiceStatus.BackgroundImageLayout = ImageLayout.Center;
        }

        public void ServiceStoppedView(FrmPrincipal frmPrincipal)
        {
            frmPrincipal.TxtPostgreSQLServiceStatus.Text = "Parado";
            frmPrincipal.BtnRestartPostgreSQL.Enabled = true;
            frmPrincipal.BtnStopPostgreSQL.Enabled = false;
            frmPrincipal.PbPostgreSQLServiceStatus.BackgroundImage = Properties.Resources.Abort;
            frmPrincipal.PbPostgreSQLServiceStatus.BackgroundImageLayout = ImageLayout.Center;
        }

        public void ServiceIsNotInstalledView(FrmPrincipal frmPrincipal)
        {
            frmPrincipal.TxtPostgreSQLServiceStatus.Text = "Não instalado";
            frmPrincipal.PbPostgreSQLServiceStatus.BackgroundImage = Properties.Resources.Danger;
            frmPrincipal.BtnRestartPostgreSQL.Enabled = false;
            frmPrincipal.BtnStopPostgreSQL.Enabled = false;
        }
    }
}
