
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class AddUserSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string groupNameIdOrGuid = "5";
            int userId = 123;

            System.DateTime dateExpires = new System.DateTime();

            cp.Group.AddUser(groupNameIdOrGuid, userId, dateExpires);

            // Return value is arbitrary for this
            // example because nothing needs to be 
            // explicitly returned to the user.
            return "";
        }
    }
}