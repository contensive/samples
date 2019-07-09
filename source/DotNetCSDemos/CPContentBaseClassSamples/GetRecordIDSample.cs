using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class GetRecordIDSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // int ID = cp.Content.GetRecordID(ContensiveExamplesModel.contentName, ContensiveExamplesModel.name);
            return "";
        }
        // Private inner model class that references the content attributes.
        private class ContensiveExamplesModel
        {
            public const string contentName = "Contensive Examples";
            public const string contentTableName = "contensiveExamples";
            private const string contentDataSource = "default";
            // Use SQL queries to get record content,
            // See CPDbBaseClass for more info.
            public string name;
        }
    }
}
