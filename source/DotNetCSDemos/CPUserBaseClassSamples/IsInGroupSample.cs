
using Contensive.BaseClasses;

namespace Samples
{
    public class IsInGroupSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string groupName = "DevGroup";
            int userId = 123;

            if( cp.User.IsInGroup(groupName, userId))
            {
                return cp.User.Name + " is in the " + groupName;
            } else
            {
                return cp.User.Name + " is not in the " + groupName;
            }
        }
    }
}

