
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class GetEditLinkSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string ContentName = "Sample Content";
            string RecordID = "2";
            string RecordName = "SampleRecord2";
            bool AllowCut = false;
            // User must be editing for the edit link to appear.
            bool IsEditing = cp.User.IsEditing(ContentName);

            string editLink = cp.Content.GetEditLink(
                ContentName, RecordID, AllowCut, RecordName, IsEditing);

            // Get a div tag with the edit link inside,
            // see CPHtmlBaseClass for more info.
            string html = cp.Html.div(editLink);

            return html;
        }
    }
}