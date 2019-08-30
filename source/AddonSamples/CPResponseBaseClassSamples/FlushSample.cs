
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class FlushSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            cp.Response.Flush();

            return "The response has been flushed.";
        }
    }
}