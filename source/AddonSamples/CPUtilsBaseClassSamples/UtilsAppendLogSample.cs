
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class UtilsAppendLogSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string logText = "This example is going " +
                "really well.";

            cp.Utils.AppendLog(logText);

            return "";
        }
    }
}