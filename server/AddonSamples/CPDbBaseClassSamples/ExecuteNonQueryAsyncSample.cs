
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class ExecuteNonQueryAsyncSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string sql = "insert into ccmembers default values;";

            // Execute the async nonquery which returns 
            // immediately.
            cp.Db.ExecuteNonQueryAsync(sql);

            // Return the number of records affected by the 
            // nonquery.
            return "The nonquery was executed.";
        }
    }
}