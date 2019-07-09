using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class DeleteContentSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            cp.Content.DeleteContent(ContensiveExamplesModel.contentName);

            // Return value is arbitrary for this
            // example because nothing needs to be 
            // explicitly returned to the user.
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
