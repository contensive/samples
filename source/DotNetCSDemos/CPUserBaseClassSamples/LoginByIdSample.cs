
using Contensive.BaseClasses;

namespace Samples
{
    public class LoginByIdSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            int recordId = 123;

            if ( cp.User.LoginByID(recordId))
            {
                return "Welcome " + cp.User.Name; ;
            } else
            {
                return "Invalid User Id.";
            }
            
        }
    }
}
