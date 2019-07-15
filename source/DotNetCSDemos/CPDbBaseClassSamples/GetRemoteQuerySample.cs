
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class GetRemoteQuerySample : AddonBaseClass
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

            return "";
        }
    }
}