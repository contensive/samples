
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class VisitGetIntegerSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // The button.
            string button = cp.Html5.Button("button", "Click me!");

            // Add both buttons to the form.
            string form = cp.Html5.Form(button);

            // Check if the user clicked the button.
            if (cp.Doc.GetText("button").Equals("Click me!"))
            {
                cp.Visit.SetProperty("timesClicked", 
                    cp.Visit.GetInteger( "timesClicked") + 1);

                return form + cp.Html5.P("You've clicked" +
                    " the button " + cp.Visit.GetInteger(
                        "timesClicked") + " times.");
            }
            // Return the initial form.
            return form;
        }
    }
}