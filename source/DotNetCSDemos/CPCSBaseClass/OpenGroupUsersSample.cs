
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class OpenGroupUsersSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Create the cs object.
            CPCSBaseClass cs = cp.CSNew();

            string groupName = "Site Managers";
            string sqlCriteria = "(memberid = " + cp.User.Id + ")";

            // Open the records in 'Member Rules'.
            if(cs.OpenGroupUsers(groupName, sqlCriteria))
            {
                return cs.GetText("memberid");
            }
            return "";
        }
    }
}