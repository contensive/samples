
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class ConvertHTML2TextSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string source = cp.Html5.Div("Hello world!");

            string text = cp.Utils.ConvertHTML2Text(source);

            return text;
        }
    }
}