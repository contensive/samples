
using Contensive.BaseClasses;

namespace Samples
{
    public class LogoutSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            cp.User.Logout();

            return "Goodbye.";
        }
    }
}
