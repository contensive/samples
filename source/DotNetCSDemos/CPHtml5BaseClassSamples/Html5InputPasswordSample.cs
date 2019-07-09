
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class Html5InputPasswordSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Input password field and submit button.
            string password = cp.Html5.InputPassword("passwordInput", 20);
            string button = cp.Html5.Button("button", "Submit");

            // Add the password field and submit button to the form.
            string innerHtml = "Input password:<br>" + password +
                "<br><br>" + button + "<br>";
            string form = cp.Html5.Form(innerHtml);

            // Check if the user clicked the submit button.
            if (cp.Doc.GetText("button").Equals("Submit"))
            {
                // Get the password they entered.
                string input = cp.Doc.GetText("passwordInput");
                string hiddenInput = input.Substring(0, 3);

                // Display the first 3 characters of the 
                // password with the rest as stars as
                // an example.
                for(int i = 0; i < input.Length - 3; i++)
                {
                    hiddenInput += "*";
                }

                // Display the form along with the user input.
                return form + cp.Html5.P("You entered:<br>" +
                    hiddenInput);
            }
            // Return the initial form.
            return form;
        }
    }
}