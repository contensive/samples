
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class Html5SelectContentSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Make the select content box and submit button.
            string selectBox = cp.Html5.SelectContent("contentInput", "", "People");
            string button = cp.Html5.Button("button", "Submit");

            // Add the select content box and submit button to the form.
            string innerHtml = "Choose your favorite person:<br>" + 
                selectBox + "<br><br>" + button + "<br>";
            string form = cp.Html5.Form(innerHtml);

            // Check if the user clicked the submit button.
            if (cp.Doc.GetText("button").Equals("Submit"))
            {
                // Get the record they selected.
                string input = cp.Doc.GetText("contentInput");
                // Display the form along with the user input.
                return form + "Thank you!";
            }
            // Return the initial form.
            return form;
        }
    }
}