
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class DocGetTextSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Prompt the user for text that displays
            // in the body of the web page. Display
            // 'Hello world!' if there is no input.
            // Will need additional JS and
            // html to show the prompt.
            string key = "displayText";
            string defaultValue = "Hello world!";

            cp.Doc.Body = cp.Doc.GetText(key, defaultValue);

            return "";
        }
    }
}