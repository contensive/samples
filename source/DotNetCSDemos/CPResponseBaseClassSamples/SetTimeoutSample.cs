
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class SetTimeoutSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string timeoutSeconds = "15";

            cp.Response.SetTimeout(timeoutSeconds);

            return "The response timeout is now " +
                timeoutSeconds + " seconds.";
        }
    }
}