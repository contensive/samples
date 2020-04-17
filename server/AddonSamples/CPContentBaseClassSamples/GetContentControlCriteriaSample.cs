using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class GetContentControlCriteriaSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string whereClause = cp.Content.GetContentControlCriteria(
                    "Sample Content");
        
            return "";
        }
    }
}
