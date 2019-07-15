
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CSSaveSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Create the cs object.
            CPCSBaseClass cs = cp.CSNew();

            if (cs.Open("People"))
            {
                // Make a change in the current row.
                cs.SetField("nickname", "super user");

                // Force a save.
                cs.Save();

                cs.Close();
            }
            return "";
        }
    }
}