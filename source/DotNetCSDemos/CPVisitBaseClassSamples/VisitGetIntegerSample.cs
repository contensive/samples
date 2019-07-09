
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class VisitGetIntegerSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // The 'AdminNavOpen' visit property is an
            // integer, but acts like a boolean. 0 is false,
            // 1 is true.
            if(cp.Visit.GetInteger("AdminNavOpen") == 1)
            {
                return "Hello, adminstrator.";
            } else
            {
                return "";
            }
        }
    }
}