using Contensive.BaseClasses;

namespace Samples
{
    public class IsQuickEditingSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string contentName = "Content Box";

            if (cp.User.IsAdvancedEditing(contentName))
            {
                return cp.User.Name + " is quick editing the "
                    + contentName;
            }
            else
            {
                return cp.User.Name + " is not quick editing the "
                    + contentName;
            }
        }
    }
}