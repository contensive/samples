
using Contensive.BaseClasses;
using System;

namespace Contensive.Samples
{
    public class EncodeDateSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // The text field for the date expression.
            string text = cp.Html5.InputText("dateExpression", 50);
            string button = cp.Html5.Button("button", "Submit");

            // Add the text field and submit button to the form.
            string innerHtml = "Input a date expression like " +
                "March 1, 2019, 03/17/2018, etc:<br>" + text +
                "<br><br>" + button + "<br>";
            string form = cp.Html5.Form(innerHtml);

            // Check if the user clicked the submit button.
            if (cp.Doc.GetText("button").Equals("Submit"))
            {
                // Encode the expression the user entered.
                string input = cp.Doc.GetText("dateExpression");
                DateTime expression = cp.Utils.EncodeDate(input);
                // Display the form along with the date
                return form + cp.Html5.P("The expression encoded " +
                    "to:<br>" + expression);
            }
            // Return the initial form.
            return form;
        }
    }
}