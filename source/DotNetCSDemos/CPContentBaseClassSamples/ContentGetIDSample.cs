using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class ContentGetIDSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            int ID = cp.Content.GetID(ContensiveExamplesModel.contentName);

            return "#" + ID + ContensiveExamplesModel.contentName;
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
