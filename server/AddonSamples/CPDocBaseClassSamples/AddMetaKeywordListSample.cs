
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class AddMetaKeywordListSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string metaKeywordList = "HTML, CSS, XML";

            cp.Doc.AddMetaKeywordList(metaKeywordList);

            // Return value is arbitrary for this
            // example because nothing needs to be 
            // explicitly returned to the user.
            return "";
        }
    }
}