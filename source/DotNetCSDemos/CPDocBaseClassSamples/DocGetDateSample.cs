
using Contensive.BaseClasses;
using System;

namespace Contensive.Samples
{
    public class DocGetDateSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Prompt a user for their DOB.
            // Will need additional JS and
            // html to show the prompt.
            string key = "dateOfBirth";

            DateTime userDoB = cp.Doc.GetDate(key);

            return "You were born in " + userDoB.Year;
        }
    }
}