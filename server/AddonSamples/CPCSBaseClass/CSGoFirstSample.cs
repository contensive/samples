
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CSGoFirstSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Create the cs object.
            CPCSBaseClass cs = cp.CSNew();

            string retVal = "";

            if (cs.Open("People"))
            {
                // Add the first ID to retVal
                retVal = "ID #" + cs.GetInteger("id");

                // Move forward in the record set
                cs.GoNext();
                retVal += " ID #" + cs.GetInteger("id");
                cs.GoNext();
                retVal += " ID #" + cs.GetInteger("id");

                // Go back to the first.
                cs.GoFirst();
                retVal += " ID #" + cs.GetInteger("id");

                cs.Close();
            }
            return retVal;
        }
    }
}