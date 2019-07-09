
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class Html5UlSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Make a few list elements to put 
            // inside a list.
            string li1 = cp.Html5.Li("Sample1");
            string li2 = cp.Html5.Li("Sample2");
            string li3 = cp.Html5.Li("Sample3");

            // Concatenate the list elements
            // together for the list.
            string innerHtml = li1 + li2 + li3;
            string unorderedList = cp.Html5.Ul(innerHtml);

            return unorderedList;
        }
    }
}