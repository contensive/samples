
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class DeleteGroupSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {

            int groupId = 3;

            cp.Group.Delete(groupId);

            // Return value is arbitrary for this
            // example because nothing needs to be 
            // explicitly returned to the user.
            return "";
        }
    }
}