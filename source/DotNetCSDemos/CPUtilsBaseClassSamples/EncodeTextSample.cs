
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class EncodeTextSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // The text field for the text expression.
            string text = cp.Html5.InputText("textExpression", 50);
            string button = cp.Html5.Button("button", "Submit");

            // Add the text field and submit button to the form.
            string innerHtml = "Input a text expression like " +
                "'Hello world!', etc:<br>" + text +
                "<br><br>" + button + "<br>";
            string form = cp.Html5.Form(innerHtml);

            // Check if the user clicked the submit button.
            if (cp.Doc.GetText("button").Equals("Submit"))
            {
                // Encode the expression the user entered.
                string input = cp.Utils.EncodeText(cp.Doc.GetText("textExpression"));
                // Display the form along with the text
                return form + cp.Html5.P("The expression encoded " +
                    "to:<br>" + input);
            }
            // Return the initial form.
            return form;
        }
    }
}