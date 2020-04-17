
using Contensive.BaseClasses;
using System.Data;

namespace Contensive.Samples
{
    public class EncodeSQLDateSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Write a SQL query with the encoded date in
            // the 'where' clause.
            string sql = "select id from ccmembers where " +
                "dateadded = " + cp.Db.EncodeSQLDate(
                    new System.DateTime(03/27/2019));

            DataTable PeopleTable = cp.Db.ExecuteQuery(sql);

            // Manipulate the DataTable here.

            return "";
        }
    }
}