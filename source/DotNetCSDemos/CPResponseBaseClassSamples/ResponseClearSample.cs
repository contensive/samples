
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class ResponseClearSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            cp.Response.Clear();

            return "Response output has been cleared.";
        }
    }
}