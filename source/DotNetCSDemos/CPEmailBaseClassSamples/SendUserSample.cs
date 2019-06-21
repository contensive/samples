
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class SendUserSample : AddonBaseClass
    {    
        public override object Execute(CPBaseClass cp)
        {
            int toUserId = 123;
            string fromAddress = cp.User.Email;

            string subject = "Hello Site Managers";
            string body = cp.Html5.P("You're doing " +
                "a great job!");

            cp.Email.sendUser(toUserId, fromAddress,
                subject, body);

            // Return value is arbitrary for this
            // example because nothing needs to be 
            // explicitly returned to the user.
            return "";
        }
    }
}