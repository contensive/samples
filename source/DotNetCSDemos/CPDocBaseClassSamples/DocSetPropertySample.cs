
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class DocSetPropertyExample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string key = "pageName";
            string value = "Page #" + cp.Doc.PageId;

            cp.Doc.SetProperty(key, value);

            // Return value is arbitrary for this
            // example because nothing needs to be 
            // explicitly returned to the user.
            return "";
        }
    }
}