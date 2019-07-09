
using Contensive.BaseClasses;
using System;

namespace Contensive.Samples
{
    public class SetCookieSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Authenticate the user for one hour.
            string key = "isAuthenticated";
            string value = "True";

            DateTime dateExpires = DateTime.Now.AddHours(1);

            cp.Response.SetCookie(key, value);
            
            return "Cookie has been set.";
        }
    }
}