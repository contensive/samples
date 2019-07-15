
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CSGetIntegerSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Create the cs object.
            CPCSBaseClass cs = cp.CSNew();

            if (cs.Open("People"))
            {
                // Get the number of visits for
                // the first people record.
                int visits =
                    cs.GetInteger("visists");

                cs.Close();

                return "Number of visits: " +
                    visits;
            }
            return "";
        }
    }
}