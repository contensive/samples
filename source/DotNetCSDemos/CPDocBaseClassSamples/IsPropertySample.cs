
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class IsPropertySample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string key = "admin site";

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