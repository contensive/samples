
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class DocGetIntegerSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // The button.
            string button = cp.Html5.Button("button", "Click me!");

            // Add both buttons to the form.
            string form = cp.Html5.Form(button);

            // Check if the user clicked the Surpise1 button.
            if (cp.Doc.GetText("button").Equals("Click me!"))
            {
                cp.Doc.SetProperty("randomInt", 
                    cp.Utils.GetRandomInteger().ToString());
                // Return the form and get the 'randomInt' 
                // Doc property with GetInteger
                return form + cp.Html5.P("Here's a random " +
                    "number: " + cp.Doc.GetInteger("randomInt"));
            }
            // Return the initial form.
            return form;
        }
    }
}