
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CSGetHtmlSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Create the cs object.
            CPCSBaseClass cs = cp.CSNew();

            if (cs.Open("People"))
            {
                cs.Close();
            }
            return "";
        }
    }
}