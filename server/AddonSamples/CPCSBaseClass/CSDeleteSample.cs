
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CSDeleteSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Create the cs object.
            CPCSBaseClass cs = cp.CSNew();

            if(cs.Open("Sample Content"))
            {
                // Delete the current row of
                // the made up content table
                cs.Delete();

                cs.Close();
            }

            return "";
        }
    }
}