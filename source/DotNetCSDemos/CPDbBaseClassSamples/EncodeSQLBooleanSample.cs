
using Contensive.BaseClasses;
using System.Data;

namespace Contensive.Samples
{
    public class EncodeSQLBooleanSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Write a SQL query with the encoded boolean in
            // the 'where' clause.
            string sql = "select id from ccmembers where " +
                "active = " + cp.Db.EncodeSQLBoolean(true);

            DataTable activePeopleList = cp.Db.ExecuteQuery(sql);

            // Manipulate the DataTable here.

            return "";
        }
    }
}