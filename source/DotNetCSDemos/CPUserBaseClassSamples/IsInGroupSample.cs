
using Contensive.BaseClasses;

namespace Samples
{
    public class IsInGroupSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string groupName = "Site Managers";
            int userId = cp.User.Id;

            if( cp.User.IsInGroup(groupName, userId))
            {
                return cp.User.Name + " belongs to the " + groupName;
            } else
            {
                return cp.User.Name + " does not belong to the " 
                    + groupName;
            }
        }
    }
}

