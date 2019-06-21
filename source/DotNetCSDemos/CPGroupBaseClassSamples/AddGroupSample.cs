
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class AddGroupSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string groupName = "Content Devs";

            cp.Group.Add(groupName);

            // Return value is arbitrary for this
            // example because nothing needs to be 
            // explicitly returned to the user.
            return "";
        }
    }
}