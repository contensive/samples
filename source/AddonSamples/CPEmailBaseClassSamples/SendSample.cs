
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class SendSample : AddonBaseClass
    {    
        public override object Execute(CPBaseClass cp)
        {
            string toAddress = "them@example.com";
            string fromAddress = "me@contensive.com";

            string subject = "Regarding the recent example";
            string body = "It was great!";

            string userErrorMessage = "Error temp";

            bool sendImmediately = true;
            bool bodyIsHTML = false;

            cp.Email.send(toAddress, fromAddress,
                subject, body, sendImmediately,
                bodyIsHTML, ref userErrorMessage);

            // Return value is arbitrary for this
            // example because nothing needs to be 
            // explicitly returned to the user.
            return "";
        }
    }
}