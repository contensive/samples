
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class DocGetBooleanSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Make a form with a button
            string makeLarge = cp.Html5.CheckBox("largerText", false);
            string makeSmall = cp.Html5.CheckBox("smallerText", false);
            string button = cp.Html5.Button("button", "Submit");
            string form = cp.Html5.Form(makeLarge + "Check " +
                "the box to make the example's text " +
                "larger<br><br>" + makeSmall + "Check " +
                "the box to make the example's text " +
                "smaller<br><br>" + button + "<br>");

            string retVal = cp.Html5.Div(form, "example");

            // Check if the user clicked the Submit button.
            if (cp.Doc.GetText("button").Equals("Submit"))
            {
                // Get the Doc boolean property that is set
                // when the user clicks the Submit button.
                if (cp.Doc.GetBoolean("largerText"))
                {
                    cp.Doc.AddHeadStyle(".example {font-size: 32px;}");

                } else if (cp.Doc.GetBoolean("smallerText"))
                {
                    cp.Doc.AddHeadStyle(".example {font-size: 12px;}");

                }
            }
            // Return the initial form.
            return retVal;
        }
    }
}