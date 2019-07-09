
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class VisitorGetNumberSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Return a made up Visitor property that 
            // records a percentage of profile completeness.
            return "Your profile is " +
                cp.Visitor.GetNumber(
                    "profileCompletionPercentage") +
                "% complete";
        }
    }
}