
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CSGetNumberSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Create the cs object.
            CPCSBaseClass cs = cp.CSNew();

            // Open a made of content table
            // containing user balances.
            if (cs.Open("User Balances"))
            {
                // Get the first person record's 
                // balance.
                double balance =
                    cs.GetNumber("balance");

                cs.Close();

                return "Current balance: $" +
                    balance;
            }
            return "";
        }
    }
}