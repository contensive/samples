
using Contensive.BaseClasses;

namespace Samples
{
    public class VisitorGetPropertySample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // If the Visitor property 'isLockedAccountTab'
            // is true, then the 'Account' tab will stay on 
            // the screen as opposed to it being hidden until
            // moused over.
            //if (cp.Visitor.GetProperty("isLockedAccountTab").Equals("True"))
            //{
                //return "The account tab is locked.";
            //}
            //else
            //{
                return "";
            //}
        }
    }
}