
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class OpenRecordSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Create the cs object.
            CPCSBaseClass cs = cp.CSNew();

            string contentName = "People";
            int recordId = cp.User.Id;
            string selectFieldList = "firstname,lastname";
            bool activeOnly = true;

            if(cs.OpenRecord(contentName, recordId, 
                selectFieldList, activeOnly))
            {
                string firstName = cs.GetText("firstname");
                string lastName = cs.GetText("lastname");

                cs.Close();

                return "Hello, " + firstName +
                    " " + lastName + "!";
            }
            return "";
        }
    }
}