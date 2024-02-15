/* Autor: William Silva (https://github.com/unclWill)
 * Data : 14/02/2024
 */

using System.Windows.Forms;
using MachineStop;

namespace DBMS_Services_Manager.View
{
    internal class MongoDBStatusView : IServiceStatusView
    {
        public void ServiceRunningView(FrmPrincipal frmPrincipal)
        {
            frmPrincipal.txtMongoDBServiceStatus.Text = "Em execução";
            frmPrincipal.btnRestartMongoDB.Enabled = false;
            frmPrincipal.btnStopMongoDB.Enabled = true;
            frmPrincipal.pbMongoDBServiceStatus.BackgroundImage = Properties.Resources.OK;
            frmPrincipal.pbMongoDBServiceStatus.BackgroundImageLayout = ImageLayout.Center;
        }

        public void ServiceStoppedView(FrmPrincipal frmPrincipal)
        {
            frmPrincipal.txtMongoDBServiceStatus.Text = "Parado";
            frmPrincipal.btnRestartMongoDB.Enabled = true;
            frmPrincipal.btnStopMongoDB.Enabled = false;
            frmPrincipal.pbMongoDBServiceStatus.BackgroundImage = Properties.Resources.Abort;
            frmPrincipal.pbMongoDBServiceStatus.BackgroundImageLayout = ImageLayout.Center;
        }
        public void ServiceIsNotInstalledView(FrmPrincipal frmPrincipal)
        {
            frmPrincipal.txtMongoDBServiceStatus.Text = "Não instalado";
            frmPrincipal.pbMongoDBServiceStatus.BackgroundImage = Properties.Resources.Danger;
            frmPrincipal.btnStopMongoDB.Enabled = false;
            frmPrincipal.btnRestartMongoDB.Enabled = false;
        }
    }
}
