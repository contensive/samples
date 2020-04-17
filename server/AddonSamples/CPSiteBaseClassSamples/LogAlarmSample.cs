
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class LogAlarmSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string cause = "";

            cp.Site.LogAlarm(cause);

            return "something";
        }
    }
}