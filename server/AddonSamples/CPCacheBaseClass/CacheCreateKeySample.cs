
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CacheCreateKeySample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            int recordId = 2;
            string tableName = "sampleContent";

            // Create the key
            string key = cp.Cache.CreateKeyForDbRecord(recordId, tableName);
            string value = cp.Content.GetRecordName("Sample Content", recordId);

            cp.Cache.Store(key, value);

            return "The name of the cached record: " + cp.Cache.GetText(key);
        }
    }
}