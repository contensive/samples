
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class DbDeleteSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Delete a made up record from a 
            // made up table.
            string tableName = "exampleTableName";
            int recordId = 2;

            cp.Db.Delete(tableName, recordId);

            return "";
        }
    }
}