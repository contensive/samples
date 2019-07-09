
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class SiteSetPropertySample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Set the site property 'ALLOWAUTOLOGIN' 
            // to true to enable auto-login.
            // cp.Site.SetProperty("ALLOWAUTOLOGIN", true);

            return "Auto-login is now enabled";
        }
    }
}