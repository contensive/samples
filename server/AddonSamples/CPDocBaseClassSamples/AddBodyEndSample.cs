
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class AddBodyEndSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // This represents a Google analytics embed link
            string googleAnalyticsEmbed = "embed link";
            cp.Doc.AddBodyEnd(googleAnalyticsEmbed);

            // Return value is arbitrary for this
            // example because nothing needs to be 
            // explicitly returned to the user.
            return "";
        }
    }
}