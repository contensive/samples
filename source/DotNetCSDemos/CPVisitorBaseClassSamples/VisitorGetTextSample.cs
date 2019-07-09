
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class VisitorGetTextSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Display made up visitor text properties to users
            // on a desktop or mobile.
            if(cp.Visitor.ForceBrowserMobile)
            {
                return cp.Visitor.GetText("mobileDisplayMessage",
                    "Hello, mobile user!");
            } else
            {
                return cp.Visitor.GetText("browserDisplayMessage",
                    "Hello, desktop user!");
            }
        }
    }
}