
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class GetListSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string errorList = cp.UserError.GetList();

            return errorList;
        }
    }
}