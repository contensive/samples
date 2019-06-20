
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class SetPropertyExample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string key = cp.Doc.PageName;
            string value = "My Page";
            cp.Doc.SetProperty(key, value);

            // Return value is arbitrary for this
            // example because nothing needs to be 
            // explicitly returned to the user.
            return "";
        }
    }
}