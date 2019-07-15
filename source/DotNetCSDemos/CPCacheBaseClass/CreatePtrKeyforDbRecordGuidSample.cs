
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CreatePtrKeyforDbRecordGuidSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string guid = "{d02fe8c2-4e8f-4c39-ae59-511f88049e0e}";
            string tableName = "sampleContent";

            // Create the key
            string key = cp.Cache.CreatePtrKeyforDbRecordGuid(guid, tableName);
            string value = cp.Content.GetRecordName("Sample Content", 3);

            cp.Cache.Store(key, value);

            return "The value of the cached record: " + cp.Cache.GetText(key)
                +"<br>The key: " + key;
        }
    }
}