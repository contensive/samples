
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class Html5H6Sample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string innerHtml = "Hello World!";

            string H6 = cp.Html5.H6(innerHtml);

            return H6;
        }
    }
}