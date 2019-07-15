
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class DocGetNumberSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Input text field and submit button.
            string text = cp.Html5.InputText("answer", 50);
            string button = cp.Html5.Button("button", "Submit");

            // Add the text field and submit button to the form.
            string innerHtml = "What is 5.75 - .13?<br>" + text 
                + "<br><br>" + button + "<br>";
            string form = cp.Html5.Form(innerHtml);

            // Check if the user clicked the submit button.
            if (cp.Doc.GetText("button").Equals("Submit"))
            {
                // Get the double value they entered with the
                // GetNumber method.
                double input = cp.Doc.GetNumber("answer");
                // Display the form along with the user input.
                if(input == 5.62)
                {
                    return form + cp.Html5.P("Correct!");
                } else
                {
                    return form + cp.Html5.P("Wrong answer!");
                }
            }
            // Return the initial form.
            return form;
        }
    }
}