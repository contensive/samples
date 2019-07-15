
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CSFieldOKSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Create the cs object.
            CPCSBaseClass cs = cp.CSNew();

            if (cs.Open("People"))
            {
                // Test if the 'name' field in
                // people is OK.
                if(cs.FieldOK("name")) {
                    cs.Close();
                    return "Field is ok.";
                }               
            }
            return "";
        }
    }
}