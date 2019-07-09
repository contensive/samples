using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class GetTableSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string content = ContensiveExamplesModel.contentName;

            string table = cp.Content.GetTable(content);

            return content + " references the " + 
                ContensiveExamplesModel.contentTableName + " table.";
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
