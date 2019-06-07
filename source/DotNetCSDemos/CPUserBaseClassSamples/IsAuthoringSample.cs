
using Contensive.BaseClasses;

namespace Samples
{
    public class IsAuthoringSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string contentName = "Content Box";

            if (cp.User.IsAuthoring(contentName))
            {
                return cp.User.Name + " is authoring the " + contentName;
            }
            else
            {
                return cp.User.Name + " is not authoring the " + contentName;
            }

        }
    }
}
