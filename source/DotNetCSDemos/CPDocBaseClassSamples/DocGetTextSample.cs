
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class DocGetTextSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Input text field and submit button.
            string text = cp.Html5.InputText("textInput", 50);
            string button = cp.Html5.Button("button", "Submit");

            // Add the text field and submit button to the form.
            string innerHtml = "Do you like cars? yes/no<br>" +
                text + "<br><br>" + button + "<br>";
            string form = cp.Html5.Form(innerHtml);

            // Check if the user clicked the submit button.
            if (cp.Doc.GetText("button").Equals("Submit"))
            {
                // Get the text they entered using GetText()
                if(cp.Doc.GetText("textInput").Equals("yes"))
                {
                    return form + cp.Html5.P("Nice!");
                } else
                {
                    return form + cp.Html5.P("Walking is fun too.");
                }           
            }
            // Return the initial form.
            return form;
        }
    }
}