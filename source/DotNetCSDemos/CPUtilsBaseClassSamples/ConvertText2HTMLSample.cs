
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class ConvertText2HTMLSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string source = "Hello world!";

            string HTML = cp.Utils.ConvertText2HTML(source);

            return HTML;
        }
    }
}