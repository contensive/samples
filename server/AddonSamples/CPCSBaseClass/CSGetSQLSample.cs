
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CSGetSQLSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Create the cs object.
            CPCSBaseClass cs = cp.CSNew();

            if (cs.Open("People"))
            {
                string sql = cs.GetSQL();

                cs.Close();

                return "The query used to generate" +
                    "the results: " + sql;
            }
            return "";
        }
    }
}