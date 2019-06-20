
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class OKSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            if(cp.UserError.OK())
            {
                return "There are no errors.";
            } else
            {
                return cp.UserError.GetList();
            }
        }
    }
}