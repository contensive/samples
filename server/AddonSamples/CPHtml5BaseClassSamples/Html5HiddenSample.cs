
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class Html5HiddenSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string htmlName = "sampleNumber";

            int htmlValue = cp.User.Id;

            string hiddenElement = cp.Html5.Hidden(htmlName, htmlValue);

            return hiddenElement;
        }
    }
}