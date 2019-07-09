
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class Html5ButtonSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // The buttons.
            string button1 = cp.Html5.Button("button", "Surprise1");
            string button2 = cp.Html5.Button("button", "Surprise2");

            // Add both buttons to the form.
            string innerHtml = button1 + "<br><br>" + button2 + "<br>";
            string form = cp.Html5.Form(innerHtml);

            // Check if the user clicked the Surpise1 button.
            if (cp.Doc.GetText("button").Equals("Surprise1"))
            {
                return form + cp.Html5.P("Wow!");

            // Check if the user clicked the Surpise2 button.
            } else if (cp.Doc.GetText("button").Equals("Surprise2"))
            {
                return form + cp.Html5.P("Woah!");
            }
            // Return the initial form.
            return form;
        }
    }
}