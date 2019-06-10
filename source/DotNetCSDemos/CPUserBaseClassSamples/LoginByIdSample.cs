
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class LoginByIdSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Use cp.User.Id to get the ID property 
            // associated with a user's account
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
