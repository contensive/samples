
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CreatePtrKeyforDbRecordUniqueNameSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Get the unique record name.
            string name = cp.Content.GetRecordName("Sample Content", 4);
            string tableName = "sampleContent";

            // Create the key.
            string key = cp.Cache.CreatePtrKeyforDbRecordGuid(name, tableName);

            cp.Cache.Store(key, name);

            return "The value of the cached record: " + cp.Cache.GetText(key)
                + "<br>The key: " + key;
        }
    }
}