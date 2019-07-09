
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class GetEditLinkSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string ContentName = ContensiveExamplesModel.contentName;
            bool AllowCut = false;
            bool IsEditing = cp.User.IsEditing(ContentName);

            ContensiveExamplesViewModel viewModel = new
                ContensiveExamplesViewModel("example", 1);

            string editLink = cp.Content.GetEditLink(
                ContentName, viewModel.id.ToString(), AllowCut, viewModel.name, IsEditing);

            // Get a div tag with the edit link inside,
            // see CPHtmlBaseClass for more info.
            string html = cp.Html.div(editLink);
            // Place the edit link at the end of the body,
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
        // Private inner view model class that references view attributes.
        private class ContensiveExamplesViewModel
        {
            public string name;
            public int id;

            public ContensiveExamplesViewModel(string name, int id)
            {
                this.name = name;
                this.id = id;
            }
        }
    }
}