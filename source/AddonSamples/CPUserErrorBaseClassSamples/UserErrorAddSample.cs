
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class UserErrorAddSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            if(cp.User.Username == null)
            {
                cp.UserError.Add("Username of current user is null.");
                return "Error occurred.";
            } else
            {
                // Return value is arbitrary for this
                // example because nothing needs to be 
                // explicitly returned to the user.
                return "";
            }
        }
    }
}