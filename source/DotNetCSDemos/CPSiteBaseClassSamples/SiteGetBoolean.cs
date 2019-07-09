
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class SiteGetBoolean : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            if(cp.Site.GetBoolean("ALLOWAUTORECOGNIZE"))
            {
                return "Auto recognize is enabled";
            } else
            {
                return "Auto recognize is disabled";
            }
        }
    }
}