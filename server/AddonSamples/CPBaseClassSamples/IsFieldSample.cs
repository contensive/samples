using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class IsFieldSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string fieldName = "exampleCode";
            string content = ContensiveExamplesModel.contentName;
            if (cp.Content.IsField(content, fieldName))
            {
                return fieldName + " is a field in " + content;
            } else
            {
                return fieldName + " is not a field in " + content;
            }
        }
        // Private inner model class that references the content attributes.
        private class ContensiveExamplesModel
        {
            public const string contentName = "Contensive Examples";
            public const string contentTableName = "contensiveExamples";
            private const string contentDataSource = "default";
            string exampleCode;
        }
    }
}
