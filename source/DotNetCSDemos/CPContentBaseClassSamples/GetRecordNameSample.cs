
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class GetRecordNameSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string ContentName = "Sample Content";
            int recordId = 1;

            string recordName = cp.Content.GetRecordName(
                ContentName, recordId);

            return "The record name is: " + recordName;
        }
    }
}