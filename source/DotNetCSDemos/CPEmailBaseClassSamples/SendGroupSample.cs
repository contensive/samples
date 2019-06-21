
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class SendGroupSample : AddonBaseClass
    {    
        public override object Execute(CPBaseClass cp)
        {
            int groupId = cp.Group.GetId("Site Managers");
            string fromAddress = "example@contensive.com";

            string subject = "Hello Site Managers";
            string body = cp.Html5.P("You're doing" +
                " a great job!");

            bool sendImmediately = true;
            bool bodyIsHtml = true;


            cp.Email.sendGroup(groupId, fromAddress,
                subject, body, sendImmediately, bodyIsHtml);

            // Return value is arbitrary for this
            // example because nothing needs to be 
            // explicitly returned to the user.
            return "";
        }
    }
}