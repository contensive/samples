
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class ResponseCloseSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            cp.Response.Close();

            return "The response has been closed.";
        }
    }
}