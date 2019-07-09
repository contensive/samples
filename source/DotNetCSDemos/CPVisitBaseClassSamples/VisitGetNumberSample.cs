
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class VisitGetNumberSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Made up Visit property that tallies the total 
            // number of hits to the application into a 
            // double value that represents a percentage to 
            // 1,000,000.
            double hitsGoalPercentage = cp.Visit.GetNumber("goalPercentage");

            return "Our goal of reaching 1,000,000 total hits is " +
                hitsGoalPercentage + "% complete.";
        }
    }
}