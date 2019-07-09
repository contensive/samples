using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class AddRecordSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string fieldName = "example field";

            int newRecordId = cp.Content.AddRecord(
                ContensiveExamplesModel.contentName, fieldName);

            return "ID#" + newRecordId + " is the new record in " +
                fieldName;
        }
        // Private inner model class that references the content attributes.
        private class ContensiveExamplesModel
        {
            public const string contentName = "Contensive Examples";
            public const string contentTableName = "contensiveExamples";
            private const string contentDataSource = "default";

        }
    }
}
