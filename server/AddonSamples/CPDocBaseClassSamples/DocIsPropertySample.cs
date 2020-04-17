
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class DocIsPropertySample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string key = "totalPageVisits";

            if (cp.Doc.IsProperty(key))
            {
                return key + " is a property.";
            }
            else
            {
                return key + " is not a property.";
            }
        }
    }
}