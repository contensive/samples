
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class AddRefreshQueryStringSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string key = "sampleKey";
            string Value = "sampleValue";

            cp.Doc.AddRefreshQueryString(key, Value);

            // Return value is arbitrary for this
            // example because nothing needs to be 
            // explicitly returned to the user.
            return "";
        }
    }
}