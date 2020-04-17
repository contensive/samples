using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class IsLockedSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string fieldName = "Sample ID";
            string content = "Sample Content";

            // Check if the field is locked
            if (cp.Content.IsLocked(content, fieldName))
            {
                return fieldName + " is locked";
            }
            else
            {
                return fieldName + " is not locked";
            }
        }
    }
}
