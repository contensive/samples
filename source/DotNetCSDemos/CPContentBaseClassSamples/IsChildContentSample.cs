using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class IsChildContentSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string ChildContentID = cp.Content.GetID(
                ChildModel.contentName).ToString();
            string ParentContentID = cp.Content.GetID(
                ParentModel.contentName).ToString();
            if (cp.Content.IsChildContent(ChildContentID, ParentContentID))
            {
                return ChildModel.contentName + " is a child of " +
                    ParentModel.contentName;
            }
            else
            {
                return ChildModel.contentName + " is not a child of " +
                    ParentModel.contentName;
            }
        }
        // Private inner model classes that referencethe content attributes.
        private class ChildModel
        {
            public const string contentName = "Child Model";
            public const string contentTableName = "childModel";
            private const string contentDataSource = "default";
        }
        private class ParentModel
        {
            public const string contentName = "Paren tModel";
            public const string contentTableName = "parentModel";
            private const string contentDataSource = "default";
        }
    }
}
