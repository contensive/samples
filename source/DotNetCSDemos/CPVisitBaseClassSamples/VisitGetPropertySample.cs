
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class VisitGetPropertySample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // The user is editing if the visit property
            // 'AllowEditing' is true.
            //if(cp.Visit.GetProperty("AllowEditing").Equals("false"))
            //{
            //    return "We know you are editing!";
            //}
            //else
            //{
                return "Hello, " + cp.User.Name + "!";
            //}
        }
    }
}