using System.Security.Principal;


namespace DBMS_Services_Manager.Controller.ExecutionPolicies
{
    internal class ElevationChecker
    {
        private bool _isElevated;

        public bool IsElevated
        {
            get
            {
                using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
                {
                    WindowsPrincipal userElevationChecker = new WindowsPrincipal(identity);
                    _isElevated = userElevationChecker.IsInRole(WindowsBuiltInRole.Administrator);
                }
                return _isElevated;
            }
        }
    }
}