/* 
 * Author: William Silva (https://github.com/unclWill)
 * Date  : 14/02/2024
 */

using System;
using System.Security.Principal;
using MachineStop;

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

        internal string WindowsElevationInfo()
        {
            return (IsElevated) ? "DBMS Services Manager (Admin)" : "DBMS Services Manager (Non-Admin)";
        }

        internal void RunWithElevatedPrivileges()
        {
            System.Diagnostics.ProcessStartInfo StartInfo = new System.Diagnostics.ProcessStartInfo
            {
                UseShellExecute = true,
                Verb = "runas",
                WorkingDirectory = Environment.CurrentDirectory,
                FileName = "DBMS Services Manager.exe",
                Arguments = @"\D -FF"
            };
            System.Diagnostics.Process p = System.Diagnostics.Process.Start(StartInfo);
        }
    }
}