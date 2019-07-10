
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class Html5InputHtmlSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Input HTML field and submit button.
            string html = cp.Html5.InputHtml("htmlInput", 500);
            string button = cp.Html5.Button("button", "Submit");

            // Add the HTML field and submit button to the form.
            string innerHtml = html + "<br><br>" + button + "<br>";
            string form = cp.Html5.Form(innerHtml);

            // Check if the user clicked the submit button.
            if (cp.Doc.GetText("button").Equals("Submit"))
            {
                // Get the HTML they entered.
                string input = cp.Doc.GetText("htmlInput");
                // Display the form along with the user input.
                return form + cp.Html5.P("Your HTML:<br><div " +
                    "style=\"border-style:solid;\">" + 
                    input + "</div>");
            }
            // Return the initial form.
            return form;
        }
    }
}