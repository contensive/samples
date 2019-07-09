
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class Html5LiSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Make a few list elements to put 
            // inside an unordered list.
            string li1 = cp.Html5.Li("Sample1");
            string li2 = cp.Html5.Li("Sample2");
            string li3 = cp.Html5.Li("Sample3");

            // Concatenate the list elements
            // together for the unordered list.
            string innerHtml = li1 + li2 + li3;
            string list = cp.Html5.Ul(innerHtml);

            return list;
        }
    }
}