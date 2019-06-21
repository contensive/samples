
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class GetGroupNameSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            int groupId = 1;

            string groupName = cp.Group.GetName(groupId);

            cp.Group.AddUser(groupName);

            // Return value is arbitrary for this
            // example because nothing needs to be 
            // explicitly returned to the user.
            return "";
        }
    }
}