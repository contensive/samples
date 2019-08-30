
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class IsTableSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // The 'People' content name.
            string tableName = "ccMembers";

            // Check if the table exists
            if(cp.Db.IsTable(tableName))
            {
                return tableName + 
                    " is a table.";
            } else
            {
                return tableName +
                    "is not a table.";
            }
        }
    }
}