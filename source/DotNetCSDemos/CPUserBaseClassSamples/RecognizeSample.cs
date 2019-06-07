
using Contensive.BaseClasses;

namespace Samples
{
    public class RecognizeSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            int userId = cp.User.Id;

            if(cp.User.Recognize(userId))
            {
                return "User is recognized.";
            } else
            {
                return "User is not recognized.";
            }
        }
    }
}