using System;
using System.Windows.Forms;

namespace MachineStop.Forms
{
    public partial class frmConfigs : Form
    {
        public frmConfigs()
        {
            InitializeComponent();
            LoadConfigs();
        }

        private void LoadConfigs()
        {
            try
            {
                DBMS_Services_Manager.Properties.Settings.Default.SQLServer_ServiceName = txtSQLServerServiceName.Text;
                DBMS_Services_Manager.Properties.Settings.Default.SQLServer_ProcessName = txtSQLServerProcessName.Text;
                DBMS_Services_Manager.Properties.Settings.Default.MySQL_ServiceName = txtMySQLServiceName.Text;
                DBMS_Services_Manager.Properties.Settings.Default.MySQL_ProcessName = txtMySQLProcessName.Text;
                DBMS_Services_Manager.Properties.Settings.Default.PostgreSQL_ServiceName = txtPostgreSQLServiceName.Text;
                DBMS_Services_Manager.Properties.Settings.Default.PostgreSQL_ProcessName = txtPostgreSQLProcessName.Text;
                DBMS_Services_Manager.Properties.Settings.Default.MariaDB_ServiceName = txtMariaDBServiceName.Text;
                DBMS_Services_Manager.Properties.Settings.Default.MariaDB_ProcessName = txtMariaDBProcessName.Text;
                DBMS_Services_Manager.Properties.Settings.Default.MongoDB_ServiceName = txtMongoDBServiceName.Text;
                DBMS_Services_Manager.Properties.Settings.Default.MongoDB_ProcessName = txtMongoDBProcessName.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar definições.\nDetalhes: {ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEnableEdit_Click(object sender, EventArgs e)
        {
            btnEnableEdit.Visible = false;
            btnConfirm.Visible = true;

            //SQLServer
            txtSQLServerProcessName.ReadOnly = false;
            //MySQL
            txtMySQLProcessName.ReadOnly = false;
            //PostgreSQL
            txtPostgreSQLProcessName.ReadOnly = false;
            //MariaDB
            txtMariaDBProcessName.ReadOnly = false;
            //MongoDB
            txtMongoDBProcessName.ReadOnly = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            btnEnableEdit.Visible = true;
            btnConfirm.Visible = false;

            //SQLServer
            txtSQLServerProcessName.ReadOnly = true;
            txtSQLServerServiceName.ReadOnly = true;
            //MySQL
            txtMySQLProcessName.ReadOnly = true;
            txtMySQLServiceName.ReadOnly = true;
            //PostgreSQL
            txtPostgreSQLServiceName.ReadOnly = true;
            txtPostgreSQLProcessName.ReadOnly = true;
            //MariaDB
            txtMariaDBServiceName.ReadOnly = true;
            txtMariaDBProcessName.ReadOnly = true;
            //MongoDB
            txtMongoDBServiceName.ReadOnly = true;
            txtMongoDBProcessName.ReadOnly = true;

            SaveSettings();
        }

        private void SaveSettings()
        {
            try
            {
                DBMS_Services_Manager.Properties.Settings.Default.SQLServer_ServiceName = txtSQLServerServiceName.Text;
                DBMS_Services_Manager.Properties.Settings.Default.SQLServer_ProcessName = txtSQLServerProcessName.Text;
                DBMS_Services_Manager.Properties.Settings.Default.MySQL_ServiceName = txtMySQLServiceName.Text;
                DBMS_Services_Manager.Properties.Settings.Default.MySQL_ProcessName = txtMySQLProcessName.Text;
                DBMS_Services_Manager.Properties.Settings.Default.PostgreSQL_ServiceName = txtPostgreSQLServiceName.Text;
                DBMS_Services_Manager.Properties.Settings.Default.PostgreSQL_ProcessName = txtPostgreSQLServiceName.Text;
                DBMS_Services_Manager.Properties.Settings.Default.MariaDB_ServiceName = txtMariaDBServiceName.Text;
                DBMS_Services_Manager.Properties.Settings.Default.MariaDB_ProcessName = txtMariaDBServiceName.Text;
                DBMS_Services_Manager.Properties.Settings.Default.MongoDB_ServiceName = txtMongoDBServiceName.Text;
                DBMS_Services_Manager.Properties.Settings.Default.MongoDB_ProcessName = txtMongoDBServiceName.Text;
                DBMS_Services_Manager.Properties.Settings.Default.Save();
                MessageBox.Show("As definições foram salvas com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //frmPrincipal.StartTimerServiceMonitor();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar as definições.\nDetalhes: {ex}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
