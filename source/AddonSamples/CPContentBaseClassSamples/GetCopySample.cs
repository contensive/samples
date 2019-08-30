using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class GetCopySample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string copyName = "Sample Copy";

            string copy = cp.Content.GetCopy(copyName);

            return "The copy: " + copy;
        }
    }
}
