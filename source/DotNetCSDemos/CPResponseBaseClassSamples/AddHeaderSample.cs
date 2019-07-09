
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class AddHeaderSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Add a header containing the charset.
            cp.Response.AddHeader("Text-encoding", 
                cp.Site.GetText("SITE CHARACTER ENCODING"));

            return "";
        }
    }
}