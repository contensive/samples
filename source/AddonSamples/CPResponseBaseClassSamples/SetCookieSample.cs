
using Contensive.BaseClasses;
using System;

namespace Contensive.Samples
{
    public class SetCookieSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Authenticate the user for one hour.
            string key = "birthday";

            // Input date field and submit button.
            string date = cp.Html5.InputDate("dateInput");
            string button = cp.Html5.Button("button", "Submit");

            // Add the date field and submit button to the form.
            string innerHtml = "Enter your birthday:<br>" +
                date + "<br><br>" + button + "<br>";
            string form = cp.Html5.Form(innerHtml);

            // Check if the user clicked the submit button.
            if (cp.Doc.GetText("button").Equals("Submit"))
            {
                // Get the date they entered.
                DateTime value = cp.Doc.GetDate("dateInput");
                // Set expiration to MaxValue so the cookie 
                // never expires.
                cp.Response.SetCookie(key, value.ToString(), 
                    DateTime.MaxValue);
                // Display the form along with the user input.
                return form + "Thank you!";
            }
            // Return the initial form.
            return form;
        }
    }
}