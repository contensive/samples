
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class LogWarningSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string name = "";
            string description = "";
            string typeOfWarningKey = "";
            string instanceKey = "";

            cp.Site.LogWarning(name, description,
                typeOfWarningKey, instanceKey);

            return "";
        }
    }
}