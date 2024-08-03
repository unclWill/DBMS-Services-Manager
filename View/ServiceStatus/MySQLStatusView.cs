/* 
 * Author: William Silva (https://github.com/unclWill)
 * Date  : 14/02/2024
 */

using System.Windows.Forms;
using MachineStop;

namespace DBMS_Services_Manager.View.ServiceStatus
{
    internal class MySQLStatusView : IServiceStatusView
    {
        public void ServiceRunningView(FrmMain frmPrincipal)
        {
            frmPrincipal.TxtMySQLServiceStatus.Text = "Em execução";
            frmPrincipal.BtnRestartMySQL.Enabled = false;
            frmPrincipal.BtnStopMySQL.Enabled = true;
            frmPrincipal.PbMySQLServiceStatus.BackgroundImage = Properties.Resources.OK;
            frmPrincipal.PbMySQLServiceStatus.BackgroundImageLayout = ImageLayout.Center;
        }

        public void ServiceStoppedView(FrmMain frmPrincipal)
        {
            frmPrincipal.TxtMySQLServiceStatus.Text = "Parado";
            frmPrincipal.BtnRestartMySQL.Enabled = true;
            frmPrincipal.BtnStopMySQL.Enabled = false;
            frmPrincipal.PbMySQLServiceStatus.BackgroundImage = Properties.Resources.Abort;
            frmPrincipal.PbMySQLServiceStatus.BackgroundImageLayout = ImageLayout.Center;
        }

        public void ServiceIsNotInstalledView(FrmMain frmPrincipal)
        {
            frmPrincipal.TxtMySQLServiceStatus.Text = "Não instalado";
            frmPrincipal.PbMySQLServiceStatus.BackgroundImage = Properties.Resources.No;
            frmPrincipal.BtnRestartMySQL.Enabled = false;
            frmPrincipal.BtnStopMySQL.Enabled = false;
        }
    }
}
