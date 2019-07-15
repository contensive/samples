
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CSGoNextSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Create the cs object.
            CPCSBaseClass cs = cp.CSNew();

            if (cs.Open("People"))
            {
                // Move to the second record
                cs.GoNext();
                // Get the name field of the second
                // record
                string name = cs.GetText("name");

                cs.Close();

                return name;
            }
            return "";
        }
    }
}