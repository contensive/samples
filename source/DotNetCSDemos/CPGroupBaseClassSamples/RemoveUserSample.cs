
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class RemoveUserSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            int userId = 123;
            string groupNameIdOrGuid = "Site Managers";

            cp.Group.RemoveUser(groupNameIdOrGuid, userId);

            // Return value is arbitrary for this
            // example because nothing needs to be 
            // explicitly returned to the user.
            return "";
        }
    }
}