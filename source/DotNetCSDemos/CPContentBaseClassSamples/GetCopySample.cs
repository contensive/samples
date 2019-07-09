using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class GetCopySample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string copyName = "Example Copy";

            string copy = cp.Content.GetCopy(copyName);

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
