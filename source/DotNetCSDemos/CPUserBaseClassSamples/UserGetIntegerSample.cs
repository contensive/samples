
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class UserGetIntegerSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Input text field and submit button.
            string ageInput = cp.Html5.InputText("age", 3);
            string button = cp.Html5.Button("button", "Submit");

            // Add the date field and submit button to the form.
            string innerHtml = "Enter your age:<br>" +
                ageInput + "<br><br>" + button + "<br>";
            string form = cp.Html5.Form(innerHtml);

            // Check if the user clicked the submit button.
            if (cp.Doc.GetText("button").Equals("Submit"))
            {
                // Set the user property.
                cp.User.SetProperty("age", cp.Doc.GetInteger("age"));

                // Get the property using User.GetInteger().
                int age = cp.User.GetInteger("age");

                // Display the form along with the user input.
                return form + cp.Html5.P("Your age is:<br>"
                    + age);
            }
            // Return the initial form.
            return form;
        }
    }
}