
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class UserGetBooleanSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // The button.
            string button1 = cp.Html5.Button("button1",
                "Click me if you drink coffee");
            string button2 = cp.Html5.Button("button2",
                "Click me if you don't drink coffee");

            // Add both buttons to the form.
            string innerHtml = button1 + "<br>" + button2 +
                "<br>";
            string form = cp.Html5.Form(innerHtml);

            // Check if the user clicked the button.
            if (cp.Doc.GetText("button1").Equals(
                "Click me if you drink coffee"))
            {
                // Set the user property
                cp.User.SetProperty("likesCoffee", true);

            } else if (cp.Doc.GetText("button2").Equals(
                "Click me if you don't drink coffee"))
            {
                // Set the user property
                cp.User.SetProperty("likesCoffee", false);
            }

            // Get the property using User.GetBoolean()
            bool opinion = cp.User.GetBoolean("likesCoffee");

            // Return the form.
            return form + cp.Html5.P(cp.User.Name +
                    " likes coffee?<br>" + opinion);
        }
    }
}