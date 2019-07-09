using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class AddContentFieldSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string content = ContensiveExamplesModel.contentName;
            string fieldName = "New Example Field";

            // See fileTypeIdEnum for info on different types.
            int newFieldId = cp.Content.AddContentField(content, fieldName,
                CPContentBaseClass.fileTypeIdEnum.Text);

            return fieldName + " ID#" + newFieldId + " is the new field in " +
                content;
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
