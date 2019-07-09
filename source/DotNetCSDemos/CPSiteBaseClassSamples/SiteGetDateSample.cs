
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class SiteGetDateSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Get the site property that records the 
            // date and time of the last Housekeeping
            // checks.
            return "The date and time of the last" +
                " check was " + cp.Site.GetDate(
                    "HOUSEKEEP, LAST CHECK");
        }
    }
}