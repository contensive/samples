
using Contensive.BaseClasses;
using System;

namespace Contensive.Samples
{
    public class DocGetDateSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Input date field and submit button.
            string date = cp.Html5.InputDate("dateOfBirth");
            string button = cp.Html5.Button("button", "Submit");

            // Add the date field and submit button to the form.
            string innerHtml = "Enter your birthday:<br>" +
                date + "<br><br>" + button + "<br>";
            string form = cp.Html5.Form(innerHtml);

            // Check if the user clicked the submit button.
            if (cp.Doc.GetText("button").Equals("Submit"))
            {
                // Get the date they entered.
                DateTime input = cp.Doc.GetDate("dateOfBirth");
                // Display the form along with the user input.
                return form + cp.Html5.P("Your birthday is:<br>" 
                    + input.ToShortDateString());
            }
            // Return the initial form.
            return form;
        }
    }
}