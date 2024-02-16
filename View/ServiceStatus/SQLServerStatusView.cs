/* 
 * Author: William Silva (https://github.com/unclWill)
 * Date  : 14/02/2024
 */

using System.Windows.Forms;
using MachineStop;

namespace DBMS_Services_Manager.View.ServiceStatus
{
    internal class SQLServerStatusView : IServiceStatusView
    {
        public void ServiceRunningView(FrmPrincipal frmPrincipal)
        {
            frmPrincipal.TxtSQLServerServiceStatus.Text = "Em execução";
            frmPrincipal.BtnRestartSQLServer.Enabled = false;
            frmPrincipal.BtnStopSQLServer.Enabled = true;
            frmPrincipal.PbSQLServerServiceStatus.BackgroundImage = Properties.Resources.OK;
            frmPrincipal.PbSQLServerServiceStatus.BackgroundImageLayout = ImageLayout.Center;
        }

        public void ServiceStoppedView(FrmPrincipal frmPrincipal)
        {
            frmPrincipal.TxtSQLServerServiceStatus.Text = "Parado";
            frmPrincipal.BtnRestartSQLServer.Enabled = true;
            frmPrincipal.BtnStopSQLServer.Enabled = false;
            frmPrincipal.PbSQLServerServiceStatus.BackgroundImage = Properties.Resources.Abort;
            frmPrincipal.PbSQLServerServiceStatus.BackgroundImageLayout = ImageLayout.Center;
        }

        public void ServiceIsNotInstalledView(FrmPrincipal frmPrincipal)
        {
            frmPrincipal.TxtSQLServerServiceStatus.Text = "Não instalado";
            frmPrincipal.PbSQLServerServiceStatus.BackgroundImage = Properties.Resources.No;
            frmPrincipal.BtnRestartSQLServer.Enabled = false;
            frmPrincipal.BtnStopSQLServer.Enabled = false;
        }
    }
}
