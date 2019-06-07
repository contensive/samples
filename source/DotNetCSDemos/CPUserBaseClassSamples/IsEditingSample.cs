
using Contensive.BaseClasses;

namespace Samples
{
    public class IsEditingSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string contentName = "Content Box";

            if(cp.User.IsEditing(contentName))
            {
                return cp.User.Name + " is editing the " + contentName;
            } else
            {
                return cp.User.Name + " is not editing the " + contentName;
            }
            
        }
    }
}
