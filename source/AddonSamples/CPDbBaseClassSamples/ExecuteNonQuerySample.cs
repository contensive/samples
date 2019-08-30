
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class ExecuteNonQuerySample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string sql = "insert into ccmembers default values;";
            int recordsAffected = 0;

            // Execute the nonquery.
            cp.Db.ExecuteNonQuery(sql, ref recordsAffected);

            // Return the number of records affected by the 
            // nonquery.
            return recordsAffected + " new record was " +
                "added to People.";
        }
    }
}