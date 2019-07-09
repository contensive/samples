using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class GetTableIDSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            int tableID = cp.Content.GetTableID(
                ContensiveExamplesModel.contentTableName);
            return "The table ID is #" + tableID;
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
