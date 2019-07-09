using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class IsLockedSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string fieldName = "exampleCode";
            string content = ContensiveExamplesModel.contentName;
            if (cp.Content.IsLocked(content, fieldName))
            {
                return fieldName + " is locked";
            }
            else
            {
                return fieldName + " is not locked";
            }
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
