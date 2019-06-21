
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class SendFormSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string toAddress = "them@example.com";
            string fromAddress = "me@contensive.com";

            string subject = "Send Form Example";

            cp.Email.sendForm(toAddress, fromAddress, subject);

            // Return value is arbitrary for this
            // example because nothing needs to be 
            // explicitly returned to the user.
            return "";
        }
    }
}