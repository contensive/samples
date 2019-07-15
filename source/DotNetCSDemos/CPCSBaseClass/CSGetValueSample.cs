
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CSGetValueSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Create the cs object.
            CPCSBaseClass cs = cp.CSNew();

            if (cs.Open("People"))
            {
                // Get the first person record's 
                // first name.
                string firstName =
                    cs.GetValue("firstname");

                cs.Close();

                return "Hello, " + firstName;
            }
            return "";
        }
    }
}