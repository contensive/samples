
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class Html5RadioBoxSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Create the radio buttons and the form elements. These
            // buttons use strings so we can use cp.Doc.GetText() to
            // distinguish between which one was selected.
            string radio1 = cp.Html5.RadioBox("radioBox", "fish", "");
            string radio2 = cp.Html5.RadioBox("radioBox", "dog", "");
            string radio3 = cp.Html5.RadioBox("radioBox", "cat", "");
            string button = cp.Html5.Button("button", "Submit");

            // Add the HTML field and submit button to the form.
            string innerHtml = "Choose your favorite type of pet:<br>" +
                radio1 + "Goldfish<br>" + radio2 + "Dog<br>" +
                radio3 + "Cat<br><br>" + button + "<br>";
            string form = cp.Html5.Form(innerHtml);

            // Check if the user clicked the submit button.
            if (cp.Doc.GetText("button").Equals("Submit"))
            {
                // Conditional statements that determine
                // which radiobox was checked.
                if(cp.Doc.GetText("radioBox").Equals("fish"))
                {
                    return form + "Fish are cool.";
                } else if (cp.Doc.GetText("radioBox").Equals("dog"))
                {
                    return form + "I like dogs too.";
                } else if (cp.Doc.GetText("radioBox").Equals("cat"))
                {
                    return form + "Cats are soft.";
                } else
                {
                    return form + "I can't pick a favorite either.";
                }
            }
            // Return the initial form.
            return form;
        }
    }
}