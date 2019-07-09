
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class Html5H4Sample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string innerHtml = "Hello World!";

            string H4 = cp.Html5.H4(innerHtml);

            return H4;
        }
    }
}