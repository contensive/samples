
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class AddTitleSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string pageTitle = "My webpage";

            cp.Doc.AddTitle(pageTitle);

            // Return value is arbitrary for this
            // example because nothing needs to be 
            // explicitly returned to the user.
            return "";
        }
    }
}