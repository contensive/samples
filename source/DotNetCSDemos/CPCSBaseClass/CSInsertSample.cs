
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CSInsertSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Create the cs object.
            CPCSBaseClass cs = cp.CSNew();

            // Insert a default record.
            cs.Insert("People");

            // Close the record set afterwards.
            cs.Close();

            return "";
        }
    }
}