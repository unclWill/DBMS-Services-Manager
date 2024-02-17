/*
 * Author: William Silva (https://github.com/unclWill)
 * Date  : 16/02/2024
 */

using DBMS_Services_Manager.Properties;

namespace DBMS_Services_Manager.Globals
{
    internal static class ServiceName
    {
        private static string sqlServerServiceName = Settings.Default.SQLServer_ServiceName;
        private static string mySqlServiceName = Settings.Default.MySQL_ServiceName;
        private static string postgreSqlServiceName = Settings.Default.PostgreSQL_ServiceName;
        private static string mariaDbServiceName = Settings.Default.MariaDB_ServiceName;
        private static string mongoDbServiceName = Settings.Default.MongoDB_ServiceName;

        internal static string SQLServer
        {
            get => sqlServerServiceName;
        }

        internal static string MySQL
        {
            get => mySqlServiceName;
        }

        internal static string PostgreSQL
        {
            get => postgreSqlServiceName;
        }

        internal static string MariaDB
        {
            get => mariaDbServiceName;
        }

        internal static string MongoDB
        {
            get => mongoDbServiceName;
        }
    }
}
