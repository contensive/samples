
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CSSetFieldSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Create the cs object.
            CPCSBaseClass cs = cp.CSNew();

            if (cs.Open("People"))
            {
                // Make a change in the current row.
                cs.SetField("firstname", "super user");

                cs.Close();
            }
            return "";
        }
    }
}