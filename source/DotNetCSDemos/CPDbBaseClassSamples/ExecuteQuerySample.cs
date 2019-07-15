
using Contensive.BaseClasses;
using System.Data;

namespace Contensive.Samples
{
    public class ExecuteQuerySample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Query ccMemberRules for all people that
            // belong to the 'Site Managers' group.
            string sql = "select memberid from ccMemberRules where " +
                "groupid = " + cp.Db.EncodeSQLNumber(1);

            // Execute the query.
            DataTable peopleTable = cp.Db.ExecuteQuery(sql);

            // Return the name of person in the first row
            // of the DataTable.
            return "The first person in the list is: " +
                cp.Content.GetRecordName(
                    "People", (int)peopleTable.Rows[0]["memberid"]);
        }
    }
}