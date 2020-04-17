
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class Html5PSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string innerHtml = "Hello world!";
            string htmlClass = "exampleClass";

            string paragraph = cp.Html5.P(innerHtml, htmlClass);

            return paragraph;
        }
    }
}