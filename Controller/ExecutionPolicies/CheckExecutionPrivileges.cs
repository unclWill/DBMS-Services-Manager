/* 
 * Author: William Silva (https://github.com/unclWill)
 * Date  : 14/02/2024
 */

using System;

namespace DBMS_Services_Manager.Controller.ExecutionPolicies
{
    internal class CheckExecutionPrivileges
    {
        internal static string RequireElevationMessage()
        {
            ElevationChecker elevationChk = new ElevationChecker();
            return (!elevationChk.IsElevated) ? "Para realizar esta operação é necessário executar o programa como Administrador!" : "Ocorreu um erro. Verifique o log de erros para mais detalhes.";
        }
    }
}