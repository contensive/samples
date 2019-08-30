
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class OpenSQLSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Create the cs object.
            CPCSBaseClass cs = cp.CSNew();

            // Query ccMemberRules for all people that
            // belong to the 'Site Managers' group
            string sql = "select memberid from ccMemberRules where " +
                "groupid = " + cp.Db.EncodeSQLNumber(1);

            // Open the record set based on the sql query.
            if(cs.OpenSQL(sql))
            {
                // Get the name of the first person.
                string firstPerson = cp.Content.GetRecordName(
                    "People", cs.GetInteger("memberid"));

                cs.Close();

                return "The first person in the list is: " +
                    firstPerson;
            }
            return "";
        }
    }
}