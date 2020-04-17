
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class LogActivitySample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Create a log when a user is editing 
            // the content box.
            if(cp.User.IsQuickEditing("contentBox"))
            {
                string message = "User is editing content box.";
                int userID = cp.User.Id;
                int organizationId = cp.User.OrganizationID;

                cp.Site.LogActivity(message, userID, organizationId);
            }

            return "";
        }
    }
}