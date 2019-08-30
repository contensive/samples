
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class LoginIsOkSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Username and password are typically 
            // retrieved from a login form.
            string usernameOrEmail = "root@contensive.com";
            string password = "Contensive";

            if(cp.User.LoginIsOK(usernameOrEmail, password))
            {
                return "Login is OK.";
            } else
            {
                return "Login is invalid.";
            }
        }
    }
}
