using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class GetRecordIDSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string ContentName = "Sample Content";
            string recordName = "SampleRecord1";

            int recordId = cp.Content.GetRecordID(
                ContentName, recordName);

            return "The record ID is: " + recordId;
        }
    }
}
