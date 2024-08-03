using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_Services_Manager.Controller.ServiceManager
{
    public enum ServiceStartupType
    {
        [Description("Automatico")]
        Automatico = 2,

        [Description("Manual")]
        Manual = 3,
    }

    //public static class EnumExtensions
    //{
    //    public static string GetDescription(this Enum value)
    //    {
    //        var field = value.GetType().GetField(value.ToString());
    //        var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));

    //        return attribute == null ? value.ToString() : attribute.Description;
    //    }
    //}
}