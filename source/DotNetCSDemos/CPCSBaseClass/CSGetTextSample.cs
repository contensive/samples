
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CSGetTextSample : AddonBaseClass
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
                    cs.GetText("firstname");

                cs.Close();

                return "Hello, " + firstName;
            }
            return "";
        }
    }
}