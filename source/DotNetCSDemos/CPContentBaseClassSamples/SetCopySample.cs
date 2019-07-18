using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class SetCopySample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string CopyName = "Sample Copy";

            cp.Content.SetCopy(CopyName, "Sample Content");

            return CopyName + " has been set.";
        }
    }
}
