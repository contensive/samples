
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class GetFormInputSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Create the cs object.
            CPCSBaseClass cs = cp.CSNew();

            // Create the form input object.
            object formInput = cs.GetFormInput("People", "lastname");
            string button = cp.Html5.Button("button", "Submit");

            // Add the form input object and submit button to the form.
            string innerHtml = formInput + "<br><br>" + button + "<br>";
            string form = cp.Html5.Form(innerHtml);

            // Check if the user clicked the submit button.
            if (cp.Doc.GetText("button").Equals("Submit"))
            {
                // Get the text they entered.
                string input = cp.User.GetText("lastname");
                // Display the form along with the user input.
                return form + cp.Html5.P("You entered:<br>" + input);
            }
            // Return the initial form.
            return form;
        }
    }
}