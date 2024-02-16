/* 
 * Author: William Silva (https://github.com/unclWill)
 * Date  : 15/02/2024
 */

using System;
using System.ComponentModel;
using System.Diagnostics;
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
            lblVersion.Text = "1.16.02.24"; // Alterar a versão nas propriedades do projeto está gerando erro.
            LblCopyright.Text = "© 2022-2024 VESO Software. Direitos reservados.";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblDeveloperRepositories_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string message = "Ir ao repositório do projeto no GitHub?";
            string link = "https://github.com/unclWill/DBMS-Services-Manager";
            OpenExternalLink(link, message);
        }

        private void lblDeveloperEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string message = "Entrar em contato via email";
            string link = "mailto://william.silva@viannasempre.com.br";
            OpenExternalLink(link, message);
        }

        private void OpenExternalLink(string link, string message)
        {
            if (MessageBox.Show(message, "Acessar link externo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Process browser = new Process();

                try
                {
                    browser.StartInfo.UseShellExecute = true;
                    browser.StartInfo.FileName = link;
                    browser.Start();
                }
                catch (Win32Exception noBrowser)
                {
                    if (noBrowser.ErrorCode == -2147467259)
                        MessageBox.Show(noBrowser.Message);
                }
                catch (Exception other)
                {
                    MessageBox.Show(other.Message);
                }
            }
        }
    }
}
