
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class Html5InputTextAreaSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Input text area field and submit button.
            string text = cp.Html5.InputTextArea("textInput", 100);
            string button = cp.Html5.Button("button", "Submit");

            // Add the text field and submit button to the form.
            string innerHtml = text + "<br><br>" + button + "<br>";
            string form = cp.Html5.Form(innerHtml);

            // Check if the user clicked the submit button.
            if (cp.Doc.GetText("button").Equals("Submit"))
            {
                // Get the text they entered.
                string input = cp.Doc.GetText("textInput");
                // Display the form along with the user input.
                return form + cp.Html5.P("You entered:<br>" + input);
            }
            // Return the initial form.
            return form;
        }
    }
}