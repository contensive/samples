
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class UserErrorGetListSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string errorList = cp.UserError.GetList();

            return errorList;
        }
    }
}