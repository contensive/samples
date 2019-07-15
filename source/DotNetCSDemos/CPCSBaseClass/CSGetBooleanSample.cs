
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CSGetBooleanSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Create the cs object.
            CPCSBaseClass cs = cp.CSNew();

            if (cs.Open("People"))
            {
                // Get the boolean of the first
                // person record's active status.
                if(cs.GetBoolean("active"))
                {
                    cs.Close();

                    return "User is active.";
                }
            }
            return "";
        }
    }
}