
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class AddHeadTagSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string emptyHeadTag = "<meta>";

            cp.Doc.AddHeadTag(emptyHeadTag);

            // Return value is arbitrary for this
            // example because nothing needs to be 
            // explicitly returned to the user.
            return "";
        }
    }
}