using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class AddRecordSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string fieldName = "Sample ID";
            string ContentName = "Sample Content";
            int newRecordId = cp.Content.AddRecord(
                ContentName, fieldName);

            return "ID#" + newRecordId + " is the new record in " +
                fieldName;
        }
    }
}
