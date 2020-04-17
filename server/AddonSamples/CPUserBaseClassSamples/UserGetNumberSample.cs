
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class UserGetNumberSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Input text field and submit button.
            string balance = cp.Html5.InputText("balance", 15);
            string button = cp.Html5.Button("button", "Submit");

            // Add the date field and submit button to the form.
            string innerHtml = "Enter your current balance" +
                " as numbers only (ex: 50.21):<br>" +
                balance + "<br><br>" + button + "<br>";
            string form = cp.Html5.Form(innerHtml);

            // Check if the user clicked the submit button.
            if (cp.Doc.GetText("button").Equals("Submit"))
            {
                // Set the user property.
                cp.User.SetProperty("currentBalance",
                    cp.Doc.GetNumber("balance"));

                // Get the property using User.GetNumber().
                double currentBalance = cp.User.GetNumber(
                    "currentBalance");

                // Display the form along with the user input.
                return form + cp.Html5.P("Your current balance" +
                    " is:<br>$" + currentBalance);
            }
            // Return the initial form.
            return form;
        }
    }
}