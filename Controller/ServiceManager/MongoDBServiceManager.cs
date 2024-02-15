﻿/* Autor: William Silva (https://github.com/unclWill)
 * Data : 15/02/2024
 */

using System.Windows.Forms;
using System;
using DBMS_Services_Manager.Controller.Services;
using DBMS_Services_Manager.Controller.ExecutionPolicies;

namespace DBMS_Services_Manager.Controller.ServiceManager
{
    internal class MongoDBServiceManager
    {
        public static void StartService()
        {
            string serviceProcessName = Properties.Settings.Default.MongoDB_ProcessName;
            Service mongoDb = new Service(serviceProcessName);
            mongoDb.StartService();
        }

        public static void StopService()
        {
            string serviceProcessName = Properties.Settings.Default.MongoDB_ProcessName;
            Service mongoDb = new Service(serviceProcessName);
            mongoDb.StopService();
        }
    }
}
