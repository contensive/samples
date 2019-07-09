using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class VisitGetTextSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string key = "displayText";
            string defaultValue = "Hello world!";

            return cp.Visit.GetText(key, defaultValue);
        }
    }
}
