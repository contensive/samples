
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class Html5InputFileSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Input text file and submit button.
            string file = cp.Html5.InputFile("fileInput");
            string button = cp.Html5.Button("button", "Submit");

            // Add the file field and submit button to the form.
            string innerHtml = file + "<br><br>" + button + "<br>";
            string form = cp.Html5.Form(innerHtml);

            // Check if the user clicked the submit button.
            if (cp.Doc.GetText("button").Equals("Submit"))
            {
                // Get the name of the file they entered.
                string input = cp.Doc.GetText("fileInput");
                // Display the form along with the file name.
                return form + cp.Html5.P("You entered:<br>" + input);
            }
            // Return the initial form.
            return form;
        }
    }
}