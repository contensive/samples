
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class VisitorSetProperty : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // If the user is new, set the made up Visitor 
            // property 'profileCompletionPercentage' 
            // to 0.0%.
            if(cp.Visitor.IsNew) {
                cp.Visitor.SetProperty(
                    "profileCompletionPercentage", 0.0);
            }
            return "";
        }
    }
}