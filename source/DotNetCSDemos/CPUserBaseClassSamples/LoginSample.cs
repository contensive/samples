
using Contensive.BaseClasses;

namespace Samples
{
    public class LoginSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Username and password are typically 
            // retrieved from a login form.
            string username = "root";
            string password = "Contesive";

            if( cp.User.Login(username, password))
            {
                return "Welcome " + cp.User.Name;
            } else
            {
                return "Please try again.";
            }
        }
    }
}
