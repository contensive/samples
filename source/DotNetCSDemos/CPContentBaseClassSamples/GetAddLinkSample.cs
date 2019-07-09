using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class GetAddLinkSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string ContentName = ContensiveExamplesModel.contentName;
            string PresetNameValueList = "";
            bool AllowPaste = false;
            bool IsEditing = cp.User.IsEditing(ContentName);

            string addLink = cp.Content.GetAddLink(ContentName, PresetNameValueList, AllowPaste, IsEditing);

            // Get a div tag with the add link inside,
            // see CPHtmlBaseClass for more info.
            string html = cp.Html.div(addLink);
            // Place the add link at the end of the body,
            // see CPDocBaseClass for more info.
            cp.Doc.AddBodyEnd(html);

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
