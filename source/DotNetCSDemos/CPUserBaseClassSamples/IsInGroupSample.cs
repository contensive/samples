
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class IsInGroupSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Specified group ID number
            string groupName = "1";
            int userId = cp.User.Id;

            if( cp.User.IsInGroup(groupName, userId))
            {
                return cp.User.Name + " belongs to the specified group";
            } else
            {
                return cp.User.Name + " does not belong to the " 
                    + "specified group";
            }
        }
    }
}

