
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class Html5CheckBoxSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Key that holds the boolean value.
            string htmlName = "exampleQuestion";
            string checkBox = cp.Html5.CheckBox(htmlName);

            string button = cp.Html5.Button("button", "Submit");

            // Add the checkbox, a message next to it, and
            // a submit button.
            string form = cp.Html5.Form(checkBox + "Click the box if " +
                "you like examples." + "<br>" + button + "<br><br>");

            // Check if the user clicked the submit button.
            if(cp.Doc.GetText("button").Equals("Submit"))
            {
                // If they clicked the checkbox.
                if(cp.Doc.GetBoolean("exampleQuestion"))
                {
                    return form + "We like them too! :)";
                } else // If they didn't click it.
                {
                    return form + "That's too bad! :(";
                }
            }
            // Return the initial form.
            return form;
        }
    }
}