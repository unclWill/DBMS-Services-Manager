/* Author: William Silva (https://github.com/unclWill)
 * Date  : 14/02/2024
 */

using System.Windows.Forms;
using MachineStop;

namespace DBMS_Services_Manager.View.ServiceStatus
{
    internal class MongoDBStatusView : IServiceStatusView
    {
        public void ServiceRunningView(FrmMain frmPrincipal)
        {
            frmPrincipal.TxtMongoDBServiceStatus.Text = "Em execução";
            frmPrincipal.BtnRestartMongoDB.Enabled = false;
            frmPrincipal.BtnStopMongoDB.Enabled = true;
            frmPrincipal.PbMongoDBServiceStatus.BackgroundImage = Properties.Resources.OK;
            frmPrincipal.PbMongoDBServiceStatus.BackgroundImageLayout = ImageLayout.Center;
        }

        public void ServiceStoppedView(FrmMain frmPrincipal)
        {
            frmPrincipal.TxtMongoDBServiceStatus.Text = "Parado";
            frmPrincipal.BtnRestartMongoDB.Enabled = true;
            frmPrincipal.BtnStopMongoDB.Enabled = false;
            frmPrincipal.PbMongoDBServiceStatus.BackgroundImage = Properties.Resources.Abort;
            frmPrincipal.PbMongoDBServiceStatus.BackgroundImageLayout = ImageLayout.Center;
        }

        public void ServiceIsNotInstalledView(FrmMain frmPrincipal)
        {
            frmPrincipal.TxtMongoDBServiceStatus.Text = "Não instalado";
            frmPrincipal.PbMongoDBServiceStatus.BackgroundImage = Properties.Resources.No;
            frmPrincipal.BtnRestartMongoDB.Enabled = false;
            frmPrincipal.BtnStopMongoDB.Enabled = false;
        }
    }
}
