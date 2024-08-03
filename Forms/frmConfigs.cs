/*
 * Author: William Silva (https://github.com/unclWill)
 * Date  : 16/02/2024
 */

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using DBMS_Services_Manager.Properties;

namespace MachineStop.Forms
{
    public partial class FrmConfigs : Form
    {
        public ComboBox CboServiceStartup
        {
            get { return cboServiceStartup; }
            set { cboServiceStartup = value; }
        }

        public FrmConfigs()
        {
            InitializeComponent();
        }

        public void LoadConfigs()
        {
            try
            {
                txtSQLServerServiceName.Text = Settings.Default.SQLServer_ServiceName;
                txtSQLServerServiceDisplayName.Text = Settings.Default.SQLServer_DisplayName;
                //
                txtMySQLServiceName.Text = Settings.Default.MySQL_ServiceName;
                txtMySQLServiceDisplayName.Text = Settings.Default.MySQL_DisplayName;
                //
                txtPostgreSQLServiceName.Text = Settings.Default.PostgreSQL_ServiceName;
                txtPostgreSQLServiceDisplayName.Text = Settings.Default.PostgreSQL_DisplayName;
                //
                txtMariaDBServiceName.Text = Settings.Default.MariaDB_ServiceName;
                txtMariaDBServiceDisplayName.Text = Settings.Default.MariaDB_DisplayName;
                //
                txtMongoDBServiceName.Text = Settings.Default.MongoDB_ServiceName;
                txtMongoDBServiceDisplayName.Text = Settings.Default.MongoDB_DisplayName;
                //
                cboServiceStartup.Text = Settings.Default.StartupMode;
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Erro ao carregar definições.\n\nDetalhes: {ex.Message}");
            }
        }

        internal void SaveConfigs()
        {
            try
            {
                SaveSettings();
                ShowSuccessMessage("As definições foram salvas com sucesso.");
            }
            catch (Win32Exception ex) when (ex.ErrorCode == -2147467259)
            {
                ShowErrorMessage("O console de serviços não pôde ser aberto.");
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Erro ao salvar as definições.\n\nDetalhes: {ex.Message}");
            }
        }

        private void SaveSettings()
        {
            Settings.Default.SQLServer_ServiceName = txtSQLServerServiceName.Text;
            Settings.Default.SQLServer_DisplayName = txtSQLServerServiceDisplayName.Text;
            //
            Settings.Default.MySQL_ServiceName = txtMySQLServiceName.Text;
            Settings.Default.MySQL_DisplayName = txtMySQLServiceDisplayName.Text;
            //
            Settings.Default.PostgreSQL_ServiceName = txtPostgreSQLServiceName.Text;
            Settings.Default.PostgreSQL_DisplayName = txtPostgreSQLServiceDisplayName.Text;
            //
            Settings.Default.MariaDB_ServiceName = txtMariaDBServiceName.Text;
            Settings.Default.MariaDB_DisplayName = txtMariaDBServiceDisplayName.Text;
            //
            Settings.Default.MongoDB_ServiceName = txtMongoDBServiceName.Text;
            Settings.Default.MongoDB_DisplayName = txtMongoDBServiceDisplayName.Text;
            //
            Settings.Default.StartupMode = cboServiceStartup.Text;
            //
            Settings.Default.Save();
        }

        private void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EnableEditing(bool enable)
        {
            btnEnableEdit.Visible = !enable;
            btnConfirm.Visible = enable;
            txtSQLServerServiceDisplayName.ReadOnly = !enable;
            txtSQLServerServiceName.ReadOnly = !enable;
            txtMySQLServiceDisplayName.ReadOnly = !enable;
            txtMySQLServiceName.ReadOnly = !enable;
            txtPostgreSQLServiceDisplayName.ReadOnly = !enable;
            txtPostgreSQLServiceName.ReadOnly = !enable;
            txtMariaDBServiceDisplayName.ReadOnly = !enable;
            txtMariaDBServiceName.ReadOnly = !enable;
            txtMongoDBServiceDisplayName.ReadOnly = !enable;
            txtMongoDBServiceName.ReadOnly = !enable;
        }

        private void FrmConfigs_Load(object sender, EventArgs e)
        {
            LoadConfigs();
        }

        private void btnOpenServicesConsole_Click(object sender, EventArgs e)
        {
            Process servicesConsole = new Process();
            try
            {
                servicesConsole.StartInfo.UseShellExecute = true;
                servicesConsole.StartInfo.FileName = "services.msc";
                servicesConsole.Start();
            }
            catch (Win32Exception ex) when (ex.ErrorCode == -2147467259)
            {
                ShowErrorMessage("O console de serviços não pôde ser aberto.");
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Erro ao abrir o console de serviços.\n\nDetalhes: {ex.Message}");
            }
        }

        private void btnEnableEdit_Click(object sender, EventArgs e)
        {
            EnableEditing(true);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SaveConfigs();
            RestartApplicationToApllySettings();
            EnableEditing(false);
        }

        private void RestartApplicationToApllySettings()
        {
            bool restart = DialogResult.Yes == MessageBox.Show("As alterações serão aplicadas na reinicialização da aplicação.\n\nDeseja reiniciar agora?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (restart)
            {
                Application.Restart();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
