
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CreateKeyForDbRecordSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            int recordId = 2;
            string tableName = "sampleContent";

            // Create the key
            string key = cp.Cache.CreateKeyForDbRecord(recordId, tableName);
            string value = cp.Content.GetRecordName("Sample Content", recordId);

            cp.Cache.Store(key, value);

            return "The value of the cached record: " + cp.Cache.GetText(key)
                + "<br>The key: " + key;
        }
    }
}