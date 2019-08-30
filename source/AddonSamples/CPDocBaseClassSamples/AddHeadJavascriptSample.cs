
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class AddHeadJavascriptSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string jsExample = "console.log(\"Hello World!\");";
            cp.Doc.AddHeadJavascript(jsExample);

            // Return value is arbitrary for this
            // example because nothing needs to be 
            // explicitly returned to the user.
            return "";
        }
    }
}