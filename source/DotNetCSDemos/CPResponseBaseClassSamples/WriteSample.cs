
using Contensive.BaseClasses;

namespace Samples
{
    public class WriteSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            cp.Response.Write("Hello World!");

            return "The content was written to the response.";
        }
    }
}