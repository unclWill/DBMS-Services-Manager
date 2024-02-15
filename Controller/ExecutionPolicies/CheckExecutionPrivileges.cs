using System;

namespace DBMS_Services_Manager.Controller.ExecutionPolicies
{
    internal class CheckExecutionPrivileges
    {
        internal static string RequireElevationMessage()
        {
            ElevationChecker elevationChk = new ElevationChecker();
            return (!elevationChk.IsElevated) ? "Para realizar esta operação é necessário executar o programa com privilégios de Administrador!" : "Ocorreu um erro";
        }
    }
}