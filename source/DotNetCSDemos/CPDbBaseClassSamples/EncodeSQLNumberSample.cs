
using Contensive.BaseClasses;
using System.Data;

namespace Contensive.Samples
{
    public class EncodeSQLNumberSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Write a SQL query with the encoded number in
            // the 'where' clause.
            string sql = "select id from ccmembers where " +
                "birthdayyear = " + cp.Db.EncodeSQLNumber(
                    1995);

            DataTable peopleTable = cp.Db.ExecuteQuery(sql);

            // Manipulate the DataTable here.

            return "";
        }
    }
}