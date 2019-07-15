
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class IsTableFieldSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // The 'People' content name.
            string tableName = "ccMembers";

            // The 'firstname' field in the
            // ccMembers table.
            string fieldName = "firstname";

            // Check if the field exists
            // in the table.
            if (cp.Db.IsTableField
                (tableName, fieldName))
            {
                return fieldName + " is a field in " +
                    tableName + ".";
            }
            else
            {
                return fieldName + " is not a field in " +
                    tableName + ".";
            }
        }
    }
}