
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class AddHeadStyleLinkSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string styleSheetLink = "https://mystyles.com";

            cp.Doc.AddHeadStyleLink(styleSheetLink);

            // Return value is arbitrary for this
            // example because nothing needs to be 
            // explicitly returned to the user.
            return "";
        }
    }
}