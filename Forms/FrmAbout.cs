/* 
 * Author: William Silva (https://github.com/unclWill)
 * Date  : 15/02/2024
 */

using System;
using System.Windows.Forms;

namespace DBMS_Services_Manager.Forms
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {
            setInformation();
        }

        private void setInformation()
        {
            lblProgramName.Text = "DBMS Services Manager";
            lblDescription.Text = "Gerenciador de Serviços de Bancos de Dados para Windows.";
            lblDeveloperName.Text = "William Silva";
            lblDeveloperRepositories.Text = "https://github.com/unclWill";
            lblDeveloperEmail.Text = "william.silva@viannasempre.com.br";
            lblVersion.Text = "1.0.15.02.24";
            LblCopyright.Text = "© 2022-2024 VESO Software. Direitos reservados.";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
