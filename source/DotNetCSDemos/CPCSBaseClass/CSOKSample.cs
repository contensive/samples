
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CSOKSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Create the cs object.
            CPCSBaseClass cs = cp.CSNew();

            if (cs.Open("People"))
            {
                string retVal = "";

                // cs.OK() is typically used in 
                // while loops to determine
                // the stopping point.
                while(cs.OK())
                {
                    retVal += cs.GetText(
                        "name") + ";";

                    // Move to the next record
                    cs.GoNext();
                }

                cs.Close();

                return retVal;
            }
            return "";
        }
    }
}