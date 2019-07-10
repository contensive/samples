
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class EncodeIntegerSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // The text field for the integer expression.
            string text = cp.Html5.InputText("intExpression", 50);
            string button = cp.Html5.Button("button", "Submit");

            // Add the text field and submit button to the form.
            string innerHtml = "Input an integer expression like " +
                "1, 2, 55, etc:<br>" + text +
                "<br><br>" + button + "<br>";
            string form = cp.Html5.Form(innerHtml);

            // Check if the user clicked the submit button.
            if (cp.Doc.GetText("button").Equals("Submit"))
            {
                // Encode the expression the user entered.
                string input = cp.Doc.GetText("intExpression");
                int expression = cp.Utils.EncodeInteger(input);
                // Display the form along with the int
                return form + cp.Html5.P("The expression encoded " +
                    "to:<br>" + expression);
            }
            // Return the initial form.
            return form;
        }
    }
}