
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class DocGetNumberSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Prompt a user for the dollar
            // amount they want to donate.
            // Will need additional JS and
            // html to show the prompt.
            string key = "donationAmount";

            double amount = cp.Doc.GetNumber(key);

            return "Donate $" + amount + "?";
        }
    }
}