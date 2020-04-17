
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class EncodeBooleanSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // The text field for the boolean expression.
            string text = cp.Html5.InputText("boolExpression", 10);
            string button = cp.Html5.Button("button", "Submit");

            // Add the text field and submit button to the form.
            string innerHtml = "Input a boolean expression like " +
                "true, false, yes, no, 0, 1, etc:<br>" + text + 
                "<br><br>" + button + "<br>";
            string form = cp.Html5.Form(innerHtml);

            // Check if the user clicked the submit button.
            if (cp.Doc.GetText("button").Equals("Submit"))
            {
                // Encode the expression the user entered.
                string input = cp.Doc.GetText("boolExpression");
                bool expression = cp.Utils.EncodeBoolean(input);
                // Display the form along with the boolean
                return form + cp.Html5.P("The expression encoded " +
                    "to:<br>" + expression);
            }
            // Return the initial form.
            return form;
        }
    }
}