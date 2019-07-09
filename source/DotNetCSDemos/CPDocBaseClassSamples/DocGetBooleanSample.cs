
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class DocGetBooleanSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Prompt the user to answer yes or
            // no to a survey question.
            // Will need additional JS and
            // html to show the prompt.
            string key = "exampleSurveyQuestion";

            bool answer = cp.Doc.GetBoolean(key);

            if(answer)
            {
                return "You answered yes.";
            } else
            {
                return "You answered no.";
            }
        }
    }
}