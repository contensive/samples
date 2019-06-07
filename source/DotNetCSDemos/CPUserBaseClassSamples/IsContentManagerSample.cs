
using Contensive.BaseClasses;

namespace Samples
{
    public class IsContentManagerSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string contentName = "Content Box";

            if (cp.User.IsContentManager(contentName))
            {
                return cp.User.Name + " is a content "
                    + "manager of " + contentName;
            } else
            {
                return cp.User.Name + " is not a content "
                   + "manager of " + contentName;
            }
        }
    }
}