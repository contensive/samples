
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class LogActivitySample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Create a log when a user is editing content.
            if(cp.User.IsEditingAnything)
            {
                string message = "User #" + cp.User.Id + " is editing.";
                int userID = cp.User.Id;
                int organizationId = cp.User.OrganizationID;

                cp.Site.LogActivity(message, userID, organizationId);
            }

            return "";
        }
    }
}