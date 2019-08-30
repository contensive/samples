
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class UserGetTextSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Input text area field and submit button.
            string text = cp.Html5.InputTextArea("bio", 100);
            string button = cp.Html5.Button("button", "Submit");

            // Add the text field and submit button to the form.
            string innerHtml = "Enter a short bio about yourself:" +
                "<br>" + text + "<br><br>" + button + "<br>";
            string form = cp.Html5.Form(innerHtml);

            // Check if the user clicked the submit button.
            if (cp.Doc.GetText("button").Equals("Submit"))
            {
                // Set the user property
                cp.User.SetProperty("userBio", cp.Doc.GetText("bio"));

                // Use User.GetText() to get the property.
                string bio = cp.User.GetText("userBio");

                // Display the form along with the user input.
                return form + cp.Html5.P("Your profile:<br>" + 
                    "<b>" + cp.User.Name + "</b><br>" +
                    bio);
            }
            // Return the initial form.
            return form;
        }
    }
}