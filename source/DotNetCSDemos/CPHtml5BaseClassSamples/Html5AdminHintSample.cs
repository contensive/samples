
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class Html5AdminHintSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {          
            string innerHtml = "Study the API docs!";

            string hint = cp.Html5.AdminHint(innerHtml);

            return hint;
        }
    }
}