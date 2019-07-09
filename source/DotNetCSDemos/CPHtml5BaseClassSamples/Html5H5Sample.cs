
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class Html5H5Sample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string innerHtml = "Hello World!";

            string H5 = cp.Html5.H5(innerHtml);

            return H5;
        }
    }
}