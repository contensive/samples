
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class AddMetaDescriptionSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string metaDescription = "Hello World!";

            cp.Doc.AddMetaDescription(metaDescription);

            // Return value is arbitrary for this
            // example because nothing needs to be 
            // explicitly returned to the user.
            return "";
        }
    }
}