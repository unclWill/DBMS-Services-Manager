/* Autor: William Silva (https://github.com/unclWill)
 * Data : 15/02/2024
 */

using System.Windows.Forms;
using System;
using DBMS_Services_Manager.Controller.Services;
using DBMS_Services_Manager.Controller.ExecutionPolicies;

namespace DBMS_Services_Manager.Controller.ServiceManager
{
    internal class MySQLServiceManager
    {
        public static void StartService()
        {
            try
            {
                string serviceProcessName = Properties.Settings.Default.MySQL_ProcessName;
                Service mySql = new Service(serviceProcessName);
                mySql.StartService();
            }
            catch (Exception ex)
            {
                string elevationMsg = CheckExecutionPrivileges.RequireElevationMessage();
                const string message = "Ocorreu um erro ao tentar iniciar o serviço";
                MessageBox.Show($"[Erro] {ex.Message}\n[Aviso] {elevationMsg}", message);
            }
        }

        public static void StopService()
        {
            try
            {
                string serviceProcessName = Properties.Settings.Default.MySQL_ProcessName;
                Service mySql = new Service(serviceProcessName);
                mySql.StopService();
            }
            catch (Exception ex)
            {
                string elevationMsg = CheckExecutionPrivileges.RequireElevationMessage();
                const string message = "Ocorreu um erro ao tentar parar o serviço";
                MessageBox.Show($"[Erro] {ex.Message}\n[Aviso] {elevationMsg}", message);
            }
        }
    }
}
