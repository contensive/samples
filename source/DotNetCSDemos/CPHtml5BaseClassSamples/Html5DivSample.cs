
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class Html5DivSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string innerHtml = "Hello world!";
            string htmlClass = "exampleClass";

            string div = cp.Html5.Div(innerHtml, htmlClass);

            return div;
        }
    }
}