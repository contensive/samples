
using Contensive.BaseClasses;
using System;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Contensive.Samples {
    /// <summary>
    /// An addon that returns information about the addon itself. Useful when debugging addon installation and multiserver configurations
    /// </summary>
    class GetInfoClass : AddonBaseClass {
        public override object Execute(CPBaseClass CP) {
            var result = new StringBuilder();
            result.Append(CP.Html.h2("Contensive"));
            result.Append(CP.Html.p("This addon returns information about the current environment."));
            result.Append(CP.Html.div("Contensive v" + CP.Version + "."));
            result.Append(CP.Html.div("Visitor: " + CP.Visitor.Id + ", isNew " + CP.Visitor.IsNew));
            result.Append(CP.Html.div("Visit: " + CP.Visit.Id + ", name [" + CP.Visit.Name + "], hits [" + CP.Visit.Pages + "]"));
            result.Append(CP.Html.div("User: " + CP.User.Id + ", name [" + CP.User.Name + "], email [" + CP.User.Email + "]"));
            result.Append(CP.Html.div("IsGuest [" + CP.User.IsGuest + "]", "", "pl-2"));
            result.Append(CP.Html.div("IsNew [" + CP.User.IsNew + "]", "", "pl-2"));
            result.Append(CP.Html.div("IsRecognized [" + CP.User.IsRecognized + "]", "", "pl-2"));
            result.Append(CP.Html.div("IsAuthenticated [" + CP.User.IsAuthenticated + "]", "", "pl-2"));
            result.Append(CP.Html.div("IsAdmin [" + CP.User.IsAdmin + "]", "", "pl-2"));
            result.Append(CP.Html.div("IsDeveloper [" + CP.User.IsDeveloper + "]", "", "pl-2"));
            result.Append(CP.Html.div("OrganizationID [" + CP.User.OrganizationID + "], lookup [" + CP.Content.GetRecordName("organizations", CP.User.OrganizationID) + "]", "", "pl-2"));
            //
            result.Append(CP.Html.div("Server Time [" + DateTime.Now.ToLongTimeString() + "]", "", ""));
            result.Append(CP.Html.div("Environment MachineName [" + Environment.MachineName + "]", "", ""));
            result.Append(CP.Html.div("Environment CurrentDirectory [" + Environment.CurrentDirectory + "]", "", ""));
            result.Append(CP.Html.div("Environment OSVersion [" + Environment.OSVersion + "]", "", ""));
            result.Append(CP.Html.div("Environment ProcessorCount [" + Environment.ProcessorCount + "]", "", ""));
            result.Append(CP.Html.div("Environment UserName [" + Environment.UserName + "]", "", ""));
            result.Append(CP.Html.div("Environment Version (CLR) [" + Environment.Version + "]", "", ""));
            //
            result.Append(CP.Html.div("Directory.GetCurrentDirectory() [" + Directory.GetCurrentDirectory() + "]", "", ""));
            result.Append(CP.Html.div("AppDomain.CurrentDomain.BaseDirectory [" + AppDomain.CurrentDomain.BaseDirectory + "]", "", ""));
            result.Append(CP.Html.div("System.AppContext.BaseDirectory [" + System.AppContext.BaseDirectory + "]", "", ""));
            result.Append(CP.Html.div("Environment.CurrentDirectory [" + Environment.CurrentDirectory + "]", "", ""));
            result.Append(CP.Html.div("this.GetType().Assembly.Location [" + this.GetType().Assembly.Location + "]", "", ""));
            //
            result.Append(CP.Html.div("ProcessorId [" + getProcessorId() + "]", "", ""));
            result.Append(CP.Html.div("GetLocalIPAddress [" + GetLocalIPAddress() + "]", "", ""));
            //
            return result.ToString();
        }
        //
        public string getProcessorId() {
            string cpuInfo = string.Empty;
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc) {
                if (cpuInfo == "") {
                    //Get only the first CPU's ID
                    cpuInfo = mo.Properties["processorID"].Value.ToString();
                    break;
                }
            }
            return cpuInfo;
        }
        //
        public static string GetLocalIPAddress() {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList) {
                if (ip.AddressFamily == AddressFamily.InterNetwork) {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
    }
}
