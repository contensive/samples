
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class AddHeadStyleSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string styleSheet = "body { background:green; }";

            cp.Doc.AddHeadStyle(styleSheet);

            // Return value is arbitrary for this
            // example because nothing needs to be 
            // explicitly returned to the user.
            return "";
        }
    }
}