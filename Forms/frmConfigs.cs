using System;
using System.Windows.Forms;

namespace MachineStop.Forms
{
    public partial class frmConfigs : Form
    {
        public frmConfigs()
        {
            InitializeComponent();
        }
            private void btnEnableEdit_Click(object sender, EventArgs e) {
            FrmPrincipal frmPrincipal = new FrmPrincipal(); //Instanciação do formulário Principal.
            frmPrincipal.StopTimerServiceMonitor();

            btnEnableEdit.Visible = false;
            btnConfirm.Visible = true;

            //SQLServer
            txtSQLServerMainService.ReadOnly = false;
            txtSQLServerSecondaryService.ReadOnly = false;
            txtSQLServerExtraService.ReadOnly = false;
            //MySQL
            txtMySQLMainService.ReadOnly = false;
            txtMySQLSecondaryService.ReadOnly = false;
            txtMySQLExtraService.ReadOnly = false;
            //PostgreSQL
            txtPostgreSQLMainService.ReadOnly = false;
            txtPostgreSQLSecondaryService.ReadOnly = false;
            txtPostgreSQLExtraService.ReadOnly = false;
            //MariaDB
            txtMariaDBMainService.ReadOnly = false;
            txtMariaDBSecondaryService.ReadOnly = false;
            txtMariaDBExtraService.ReadOnly = false;
            //MongoDB
            txtMongoDBMainService.ReadOnly = false;
            txtMongoDBSecondaryService.ReadOnly = false;
            txtMongoDBExtraService.ReadOnly = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal(); //Instanciação do formulário Principal.
            frmPrincipal.StartTimerServiceMonitor();

            btnEnableEdit.Visible = true;
            btnConfirm.Visible = false;

            //SQLServer
            txtSQLServerMainService.ReadOnly = true;
            txtSQLServerSecondaryService.ReadOnly = true;
            txtSQLServerExtraService.ReadOnly = true;
            //MySQL
            txtMySQLMainService.ReadOnly = true;
            txtMySQLSecondaryService.ReadOnly = true;
            txtMySQLExtraService.ReadOnly = true;
            //PostgreSQL
            txtPostgreSQLMainService.ReadOnly = true;
            txtPostgreSQLSecondaryService.ReadOnly = true;
            txtPostgreSQLExtraService.ReadOnly = true;
            //MariaDB
            txtMariaDBMainService.ReadOnly = true;
            txtMariaDBSecondaryService.ReadOnly = true;
            txtMariaDBExtraService.ReadOnly = true;
            //MongoDB
            txtMongoDBMainService.ReadOnly = true;
            txtMongoDBSecondaryService.ReadOnly = true;
            txtMongoDBExtraService.ReadOnly = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
