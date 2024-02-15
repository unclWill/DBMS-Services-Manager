/* Autor: William Silva (https://github.com/unclWill)
 * Data : 14/02/2024
 */

using System.Security.Principal;

namespace DBMS_Services_Manager.Controller.ExecutionPolicies
{
    internal class ElevationChecker
    {
        public bool IsElevated
        {
            get
            {
                using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
                {
                    WindowsPrincipal userElevationChecker = new WindowsPrincipal(identity);
                    return userElevationChecker.IsInRole(WindowsBuiltInRole.Administrator);
                }
            }
        }
    }
}