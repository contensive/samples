
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class GetIdByLoginSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string username = "root";
            string password = "Contensive";

            int localMemberId = cp.User.GetIdByLogin(username, password);

            if(localMemberId != 0)
            {
                return "The requested user ID number is " + localMemberId;
            } else
            {
                // return 0 if ID number is not found
                return "Could not find the requested user ID"
                    + " or does not exist in the system.";
            }
        }
    }
}