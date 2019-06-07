
using Contensive.BaseClasses;

namespace Samples
{
    public class IsAdvancedEditingSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string contentName = "Content Box";

            if (cp.User.IsAdvancedEditing(contentName))
            {
                return cp.User.Name + " is advanced editing the "
                    + contentName;
            } else
            {
                return cp.User.Name + " is not advanced editing the "
                    + contentName;
            }
        }
    }
}