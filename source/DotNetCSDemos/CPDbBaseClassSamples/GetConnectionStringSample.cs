
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class GetConnectionStringSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string connectionString = cp.Db.GetConnectionString();

            // Create your own database instance here.

            return ""; 
        }
    }
}