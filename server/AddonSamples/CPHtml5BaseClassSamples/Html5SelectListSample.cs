
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class Html5SelectListSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Make the option list a constant
            const string optionList = "A,B,C,D,F";
            // Split the list into an array because 
            // the user's selection will return an index.
            string[] list = optionList.Split(',');

            // Make the select list box and submit button.
            string selectBox = cp.Html5.SelectList("listInput", "", optionList);
            string button = cp.Html5.Button("button", "Submit");

            // Add the select content box and submit button to the form.
            string innerHtml = "How would you grade this example:<br>" +
                selectBox + "<br><br>" + button + "<br>";
            string form = cp.Html5.Form(innerHtml);

            // Check if the user clicked the submit button.
            if (cp.Doc.GetText("button").Equals("Submit"))
            {
                // Get the grade they selected.
                int i = cp.Doc.GetInteger("listInput");

                string grade = "You must select a grade.";

                // Make sure they selected a grade because
                // the indexing starts at 1.
                if(i > 0)
                {
                    grade = "You gave this example a(n) " +
                    list[i - 1] + ".";
                }
                // Display the form along with the user input.
                return form + grade;
            }
            // Return the initial form.
            return form;
        }
    }
}