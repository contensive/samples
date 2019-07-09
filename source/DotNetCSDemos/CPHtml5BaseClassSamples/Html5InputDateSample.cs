
using Contensive.BaseClasses;
using System;

namespace Contensive.Samples
{
    public class Html5InputDateSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Input date field and submit button.
            string date = cp.Html5.InputDate("dateInput");
            string button = cp.Html5.Button("button", "Submit");

            // Add the date field and submit button to the form.
            string innerHtml = date + "<br><br>" + button + "<br>";
            string form = cp.Html5.Form(innerHtml);

            // Check if the user clicked the submit button.
            if (cp.Doc.GetText("button").Equals("Submit"))
            {
                // Get the date they entered.
                DateTime input = cp.Doc.GetDate("dateInput");
                // Display the form along with the user input.
                return form + cp.Html5.P("You entered:<br>" + input);
            }
            // Return the initial form.
            return form;
        }
    }
}