using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class GetContentControlCriteriaSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string whereClause = cp.Content.GetContentControlCriteria(
                    ContensiveExamplesModel.contentName);

            
            return "";
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
