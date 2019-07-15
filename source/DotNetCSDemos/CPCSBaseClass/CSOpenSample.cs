
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CSOpenSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Create the cs object.
            CPCSBaseClass cs = cp.CSNew();

            // Open the content.
            if (cs.Open("People"))
            {
                // Manipulate the content here.

                // Close the content before
                // returning.
                cs.Close();
            }
            return "";
        }
    }
}