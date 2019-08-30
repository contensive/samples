
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class VisitGetBooleanSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // The user is editing if the visit property
            // 'AllowEditing' is true.
            if(cp.Visit.GetBoolean("AllowEditing"))
            {
                return "We know you are editing!";
            }
            else
            {
                return "Hello, " + cp.User.Name + "!";
            }
        }
    }
}