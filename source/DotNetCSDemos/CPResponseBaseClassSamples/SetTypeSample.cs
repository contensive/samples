
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class SetTypeSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string contentType = "Email";

            cp.Response.SetType(contentType);

            return "The response type has been set.";
        }
    }
}