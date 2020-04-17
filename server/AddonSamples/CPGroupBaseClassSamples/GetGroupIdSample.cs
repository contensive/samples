
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class GetGroupIdSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            int groupId = cp.Group.GetId("Site Managers");

            // Add current user to Site Managers
            cp.Group.AddUser(groupId);

            // Return value is arbitrary for this
            // example because nothing needs to be 
            // explicitly returned to the user.
            return "";
        }
    }
}