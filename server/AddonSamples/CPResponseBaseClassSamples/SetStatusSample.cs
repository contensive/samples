
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class SetStatusSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            cp.Response.SetStatus("200 Success");

            return "The response status was set.";
        }
    }
}