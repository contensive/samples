
using Contensive.BaseClasses;
using System;

namespace Contensive.Samples
{
    public class ErrorReportSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Try to get a null property as an 
            // example. 
            try
            {
                cp.Site.GetText(null);
            } catch (NullReferenceException Ex)
            {
                cp.Site.ErrorReport(Ex, "Property" +
                    " is null.");
            }
            return "";
        }
    }
}