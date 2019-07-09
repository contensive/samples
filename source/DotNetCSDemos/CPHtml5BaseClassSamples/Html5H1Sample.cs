
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class Html5H1Sample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string innerHtml = "Hello World!";

            string H1 = cp.Html5.H1(innerHtml);

            return H1;
        }
    }
}