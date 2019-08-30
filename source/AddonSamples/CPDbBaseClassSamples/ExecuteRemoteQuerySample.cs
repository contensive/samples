
using Contensive.BaseClasses;
using System.Data;

namespace Contensive.Samples
{
    public class ExecuteRemoteQuerySample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Query ccMemberRules for all people that
            // belong to the 'Site Managers' group
            string sql = "select memberid from ccMemberRules where " +
                "groupid = " + cp.Db.EncodeSQLNumber(1);

            // Get the remote query key.
            string key = cp.Db.GetRemoteQueryKey(sql);

            // Execute remote query here.
            DataTable peopleTable = cp.Db.ExecuteRemoteQuery(key);

            return "The first person in the list is: " +
                cp.Content.GetRecordName(
                    "People", (int)peopleTable.Rows[0]["memberid"]);
        }
    }
}