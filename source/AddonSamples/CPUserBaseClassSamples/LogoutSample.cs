
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class LogoutSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            cp.User.Logout();

            return "You have been logged out";
        }
    }
}
