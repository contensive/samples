
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class RedirectSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Redirect to the current domain.
            cp.Response.Redirect(cp.Site.Domain);

            return "";
        }
    }
}