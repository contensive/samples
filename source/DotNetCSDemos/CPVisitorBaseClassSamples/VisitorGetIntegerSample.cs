using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class VisitorGetInteger : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // If the Visitor property 'AllowAdminTabs'
            // is true, then the current visitor is an
            // authenticated admin.
            if(cp.Visitor.GetInteger("AllowAdminTabs") == 1)
            {
                return "Edit wisely, " + cp.User.Name + ".";
            } else
            {
                return "";
            }
        }
    }
}
