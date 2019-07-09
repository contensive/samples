
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class VisitorGetDateSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Display a made up Visitor property that
            // records the date each visitor visitted.
            return "The last visitor was here on " +
                cp.Visitor.GetDate("lastVisitorDate") + ".";
        }
    }
}