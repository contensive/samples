
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class SiteGetTextSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Get the Site property that holds the 
            // site's character encoding.
            return "The site's character encoding is " +
                cp.Site.GetText("SITE CHARACTER ENCODING");
        }
    }
}