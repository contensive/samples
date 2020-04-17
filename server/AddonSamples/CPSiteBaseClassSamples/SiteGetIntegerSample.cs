
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class SiteGetIntegerSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Get the site property that dictates the 
            // allowed number of login attempts.
            return "The maximum ammount of login attempts" +
                "is: " + cp.Site.GetInteger(
                    "MAXVISITLOGINATTEMPTS") + " attempts.";
        }
    }
}