
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CreateKeySample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Create a complicated objext to cache.
            MyComplicatedPersonRecord sampleRecord = 
                new MyComplicatedPersonRecord();
            sampleRecord.firstname = "John";
            sampleRecord.lastname = "Smith";
            sampleRecord.ID = 1;
            sampleRecord.organizationName = "Contensive";

            // Create an arbitrary domain model name.
            string objectName = "complicatedPersonRecord1";
            // Use the record's ID number.
            string objectUniqueIdentifier = 
                sampleRecord.ID.ToString();

            // Create the key.
            string key = cp.Cache.CreateKey(objectName, 
                objectUniqueIdentifier);

            cp.Cache.Store(key, sampleRecord);

            return "";
        }

        private class MyComplicatedPersonRecord
        {
            public string firstname;
            public string lastname;
            public int ID;
            public string organizationName;
        }
    }
}