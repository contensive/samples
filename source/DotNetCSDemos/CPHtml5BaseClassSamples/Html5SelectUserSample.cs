
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class Html5SelectUserSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Make the select user box and submit button.
            // ID #1 is 'Site Managers'.
            string selectBox = cp.Html5.SelectUser("userInput", 0, 1, 
                "You must select a user.");
            string button = cp.Html5.Button("button", "Submit");

            // Add the select user box and submit button to the form.
            string innerHtml = "Select a user from Site Managers:<br>" +
                selectBox + "<br><br>" + button + "<br>";
            string form = cp.Html5.Form(innerHtml);

            // Check if the user clicked the submit button.
            if (cp.Doc.GetText("button").Equals("Submit"))
            {
                // Get the user they selected.
                string input = cp.Doc.GetText("userInput");
                // Display the form along with the user input.
                return form + "Thank you!";
            }
            // Return the initial form.
            return form;
        }
    }
}