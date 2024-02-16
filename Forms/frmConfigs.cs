using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace MachineStop.Forms
{
    public partial class FrmConfigs : Form
    {
        public FrmConfigs()
        {
            InitializeComponent();
        }

        private void btnEnableEdit_Click(object sender, EventArgs e)
        {
            btnEnableEdit.Visible = false;
            btnConfirm.Visible = true;
            txtSQLServerServiceName.ReadOnly = false;
            txtMySQLServiceName.ReadOnly = false;
            txtPostgreSQLServiceName.ReadOnly = false;
            txtMariaDBServiceName.ReadOnly = false;
            txtMongoDBServiceName.ReadOnly = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            btnEnableEdit.Visible = true;
            btnConfirm.Visible = false;
            txtSQLServerServiceName.ReadOnly = true;
            txtSQLServerServiceDisplayName.ReadOnly = true;
            txtMySQLServiceName.ReadOnly = true;
            txtMySQLServiceDisplayName.ReadOnly = true;
            txtPostgreSQLServiceDisplayName.ReadOnly = true;
            txtPostgreSQLServiceName.ReadOnly = true;
            txtMariaDBServiceDisplayName.ReadOnly = true;
            txtMariaDBServiceName.ReadOnly = true;
            txtMongoDBServiceDisplayName.ReadOnly = true;
            txtMongoDBServiceName.ReadOnly = true;
            SaveConfigs();
        }

        private void SaveConfigs()
        {
            try
            {
                DBMS_Services_Manager.Properties.Settings.Default.SQLServer_ServiceName = txtSQLServerServiceName.Text;
                DBMS_Services_Manager.Properties.Settings.Default.SQLServer_DisplayName = txtSQLServerServiceDisplayName.Text;

                DBMS_Services_Manager.Properties.Settings.Default.MySQL_ServiceName = txtMySQLServiceName.Text;
                DBMS_Services_Manager.Properties.Settings.Default.MySQL_DisplayName = txtMySQLServiceDisplayName.Text;

                DBMS_Services_Manager.Properties.Settings.Default.PostgreSQL_ServiceName = txtPostgreSQLServiceName.Text;
                DBMS_Services_Manager.Properties.Settings.Default.PostgreSQL_DisplayName = txtPostgreSQLServiceDisplayName.Text;

                DBMS_Services_Manager.Properties.Settings.Default.MariaDB_ServiceName = txtMariaDBServiceName.Text;
                DBMS_Services_Manager.Properties.Settings.Default.MariaDB_DisplayName = txtMariaDBServiceDisplayName.Text;

                DBMS_Services_Manager.Properties.Settings.Default.MongoDB_ServiceName = txtMongoDBServiceName.Text;
                DBMS_Services_Manager.Properties.Settings.Default.MongoDB_DisplayName = txtMongoDBServiceDisplayName.Text;

                DBMS_Services_Manager.Properties.Settings.Default.Save();

                MessageBox.Show("As definições foram salvas com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar as definições.\n\nDetalhes: {ex}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void LoadConfigs()
        {
            try
            {
                DBMS_Services_Manager.Properties.Settings.Default.SQLServer_ServiceName = txtSQLServerServiceName.Text;
                DBMS_Services_Manager.Properties.Settings.Default.SQLServer_DisplayName = txtSQLServerServiceDisplayName.Text;

                DBMS_Services_Manager.Properties.Settings.Default.MySQL_ServiceName = txtMySQLServiceName.Text;
                DBMS_Services_Manager.Properties.Settings.Default.MySQL_DisplayName = txtMySQLServiceDisplayName.Text;

                DBMS_Services_Manager.Properties.Settings.Default.PostgreSQL_ServiceName = txtPostgreSQLServiceName.Text;
                DBMS_Services_Manager.Properties.Settings.Default.PostgreSQL_DisplayName = txtPostgreSQLServiceDisplayName.Text;

                DBMS_Services_Manager.Properties.Settings.Default.MariaDB_ServiceName = txtMariaDBServiceName.Text;
                DBMS_Services_Manager.Properties.Settings.Default.MariaDB_DisplayName = txtMariaDBServiceDisplayName.Text;

                DBMS_Services_Manager.Properties.Settings.Default.MongoDB_ServiceName = txtMongoDBServiceName.Text;
                DBMS_Services_Manager.Properties.Settings.Default.MongoDB_DisplayName = txtMongoDBServiceDisplayName.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar definições.\nDetalhes: {ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                catch (Win32Exception noServiceConsole)
                {
                    if (noServiceConsole.ErrorCode == -2147467259)
                        MessageBox.Show(noServiceConsole.Message);
                }
                catch (Exception other)
                {
                    MessageBox.Show(other.Message);
                }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
