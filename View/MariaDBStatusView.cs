/* Autor: William Silva (https://github.com/unclWill)
 * Data : 14/02/2024
 */

using System.Windows.Forms;
using MachineStop;

namespace DBMS_Services_Manager.View
{
    internal class MariaDBStatusView : IServiceStatusView
    {
        public void ServiceRunningView(FrmPrincipal frmPrincipal)
        {
            frmPrincipal.txtMariaDBServiceStatus.Text = "Em execução";
            frmPrincipal.btnRestartMariaDB.Enabled = false;
            frmPrincipal.btnStopMariaDB.Enabled = true;
            frmPrincipal.pbMariaDBServiceStatus.BackgroundImage = Properties.Resources.OK;
            frmPrincipal.pbMariaDBServiceStatus.BackgroundImageLayout = ImageLayout.Center;
        }

        public void ServiceStoppedView(FrmPrincipal frmPrincipal)
        {
            frmPrincipal.txtMariaDBServiceStatus.Text = "Parado";
            frmPrincipal.btnRestartMariaDB.Enabled = true;
            frmPrincipal.btnStopMariaDB.Enabled = false;
            frmPrincipal.pbMariaDBServiceStatus.BackgroundImage = Properties.Resources.Abort;
            frmPrincipal.pbMariaDBServiceStatus.BackgroundImageLayout = ImageLayout.Center;
        }

        public void ServiceIsNotInstalledView(FrmPrincipal frmPrincipal)
        {
            frmPrincipal.txtMariaDBServiceStatus.Text = "Não instalado";
            frmPrincipal.pbMariaDBServiceStatus.BackgroundImage = Properties.Resources.Danger;
            frmPrincipal.btnStopMariaDB.Enabled = false;
            frmPrincipal.btnRestartMariaDB.Enabled = false;
        }
    }
}
