
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class SendPasswordSample : AddonBaseClass
    {    
        public override object Execute(CPBaseClass cp)
        {
            string userEmailAddress = "them@example.com";

            cp.Email.sendPassword(userEmailAddress);

            // Return value is arbitrary for this
            // example because nothing needs to be 
            // explicitly returned to the user.
            return "";
        }
    }
}