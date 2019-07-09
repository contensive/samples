
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class SetBufferSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            cp.Response.SetBuffer(true);

            return "The response buffer is now activated.";
        }
    }
}