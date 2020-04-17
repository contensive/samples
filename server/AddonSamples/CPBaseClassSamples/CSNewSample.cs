
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CSNewSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Insert a new content row. See
            // CPCSBaseClass for more info.
            CPCSBaseClass newCS = cp.CSNew();

            newCS.Insert("amountRemaining");

            // Return value is arbitrary for this
            // example because nothing needs to be 
            // explicitly returned to the user.
            return "";
        }
    }
}