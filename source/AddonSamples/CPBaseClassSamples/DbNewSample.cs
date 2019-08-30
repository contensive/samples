
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class DbNewSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Create a new Db and dispose of it.
            // See CPDbBaseClass for more info.
            string dataSourceName = "exampleDb";
            CPDbBaseClass newDb = cp.DbNew(dataSourceName);

            newDb.Dispose();

            // Return value is arbitrary for this
            // example because nothing needs to be 
            // explicitly returned to the user.
            return "";
        }
    }
}