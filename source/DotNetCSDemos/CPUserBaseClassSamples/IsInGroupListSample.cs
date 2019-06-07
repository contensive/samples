
using Contensive.BaseClasses;

namespace Samples
{
    public class IsInGroupListSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string groupIdCommaList = "Site Managers,"
                + " Content Devs";
            int userId = cp.User.Id;

            if(cp.User.IsInGroupList(groupIdCommaList, userId))
            {
                return cp.User.Name + " belongs to one or more"
                    + " of the listed groups.";
            } else
            {
                return cp.User.Name + " does not belongs to any"
                    + " of the listed groups.";
            }
        }
    }
}