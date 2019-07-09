using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class GetDataSourceSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string DS = cp.Content.GetDataSource(ContensiveExamplesModel.contentName);

            return ContensiveExamplesModel.contentName + " belongs to the " +
                DS + " data source.";
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
