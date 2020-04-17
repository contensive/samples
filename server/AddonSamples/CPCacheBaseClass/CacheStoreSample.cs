
using Contensive.BaseClasses;
using System;

namespace Contensive.Samples
{
    public class CacheStoreSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Get the unique record name
            string name = cp.Content.GetRecordName("Sample Content", 5);
            string tableName = "sampleContent";

            // Create the key
            string key = cp.Cache.CreatePtrKeyforDbRecordGuid(name, tableName);

            // Cache will invalidate in 5 days from creation
            DateTime invalidationDate = DateTime.Now.AddDays(5);

            // Cache will invalidate if any changes are made to the 
            // Sample Content table.
            string dependentKey = cp.Cache.CreateKeyForDbRecord(5, "sampleContent");

            // Cache the object
            cp.Cache.Store(key, name, invalidationDate, dependentKey);

            return "The value of the cached record: " + cp.Cache.GetText(key)
                + "<br>The key: " + key;
        }
    }
}