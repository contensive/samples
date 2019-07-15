
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CSGetRowCountSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Create the cs object.
            CPCSBaseClass cs = cp.CSNew();

            if (cs.Open("People"))
            {
                // Get the row count of the 
                // current record set returned by
                // open.
                int rowCount = cs.GetRowCount();

                cs.Close();

                return "The opened record set has " +
                    rowCount + " row(s)";
            }
            return "";
        }
    }
}