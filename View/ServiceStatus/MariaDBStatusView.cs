/*
 * Author: William Silva (https://github.com/unclWill)
 * Date  : 14/02/2024
 */

using System.Windows.Forms;
using MachineStop;

namespace DBMS_Services_Manager.View.ServiceStatus
{
    internal class MariaDBStatusView : IServiceStatusView
    {
        public void ServiceRunningView(FrmPrincipal frmPrincipal)
        {
            frmPrincipal.TxtMariaDBServiceStatus.Text = "Em execução";
            frmPrincipal.BtnRestartMariaDB.Enabled = false;
            frmPrincipal.BtnStopMariaDB.Enabled = true;
            frmPrincipal.PbMariaDBServiceStatus.BackgroundImage = Properties.Resources.OK;
            frmPrincipal.PbMariaDBServiceStatus.BackgroundImageLayout = ImageLayout.Center;
        }

        public void ServiceStoppedView(FrmPrincipal frmPrincipal)
        {
            frmPrincipal.TxtMariaDBServiceStatus.Text = "Parado";
            frmPrincipal.BtnRestartMariaDB.Enabled = true;
            frmPrincipal.BtnStopMariaDB.Enabled = false;
            frmPrincipal.PbMariaDBServiceStatus.BackgroundImage = Properties.Resources.Abort;
            frmPrincipal.PbMariaDBServiceStatus.BackgroundImageLayout = ImageLayout.Center;
        }

        public void ServiceIsNotInstalledView(FrmPrincipal frmPrincipal)
        {
            frmPrincipal.TxtMariaDBServiceStatus.Text = "Não instalado";
            frmPrincipal.PbMariaDBServiceStatus.BackgroundImage = Properties.Resources.No;
            frmPrincipal.BtnRestartMariaDB.Enabled = false;
            frmPrincipal.BtnStopMariaDB.Enabled = false;
        }
    }
}
