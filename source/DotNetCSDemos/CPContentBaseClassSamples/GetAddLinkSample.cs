using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class GetAddLinkSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string ContentName = "Sample Content";
            string PresetNameValueList = "";
            bool AllowPaste = false;
            // User must be editing for add link to appear.
            bool IsEditing = cp.User.IsEditing(ContentName);

            string addLink = cp.Content.GetAddLink(ContentName, PresetNameValueList, AllowPaste, IsEditing);

            // Get a div tag with the add link inside,
            // see CPHtmlBaseClass for more info.
            string html = cp.Html.div(addLink);

            return html;
        }
    }
}
