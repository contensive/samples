
using Contensive.BaseClasses;
using System.Data;

namespace Contensive.Samples
{
    public class EncodeSQLTextSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Write a SQL query with the encoded text in
            // the 'where' clause.
            string sql = "select id from ccmembers where " +
                "name = " + cp.Db.EncodeSQLText(
                    cp.User.Name);

            DataTable peopleTable = cp.Db.ExecuteQuery(sql);

            // Manipulate the DataTable here.

            return "";
        }
    }
}