
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class DocGetIntegerSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Prompt a for the quanitity
            // of a product they want to
            // purchase.
            // Will need additional JS and
            // html to show the prompt.
            string key = "purchaseQuantity";

            int quantity = cp.Doc.GetInteger(key);

            return "Purchase " + quantity + " items?";
        }
    }
}