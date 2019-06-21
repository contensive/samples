
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class SendSystemSample : AddonBaseClass
    {    
        public override object Execute(CPBaseClass cp)
        {
            int emailId = 123;
            string additionalCopy = "idk";

            int additionalUserId = 321;

            cp.Email.sendSystem(emailId, additionalCopy, additionalUserId);

            // Return value is arbitrary for this
            // example because nothing needs to be 
            // explicitly returned to the user.
            return "";
        }
    }
}