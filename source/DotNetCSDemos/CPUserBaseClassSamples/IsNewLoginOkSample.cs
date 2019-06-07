
using Contensive.BaseClasses;

namespace Samples
{
    public class IsNewLoginOkSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Username and password are typically 
            // retrieved from a login form.
            string usernameOrEmail = "newUser";
            string password = "newPassword";

            if(cp.User.IsNewLoginOK(usernameOrEmail, password))
            {
                return "Provided credentials are valid"
                    + " and do not exist in user database.";
            } else
            {
                return "Credentials are not valid"
                    + " or they already exist in the system.";
            }
        }
    }
}