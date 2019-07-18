using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class VisitorGetBooleanSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // If the Visitor property 'isLockedAccountTab'
            // is true, then the 'Account' tab will stay on 
            // the screen as opposed to it being hidden until
            // moused over.
            if(cp.Visitor.GetBoolean("isLockedAccountTab"))
            {
                return "The account tab is locked.";
            } else
            {
                return "";
            }
        }
    }
}
