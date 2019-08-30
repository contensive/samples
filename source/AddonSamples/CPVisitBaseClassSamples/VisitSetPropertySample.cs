
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class VisitSetPropertySample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Example code taken from design block of this page.
            // See ApiPageClass.cs in the Contensive/Samples repo.
            if( cp.Doc.GetBoolean("publish"))
            {
                // The properties that enable editing are
                // boolean cp.Visit properties, so setting them
                // to false will allow changes to be published
                // without edit tags.
                cp.Visit.SetProperty("AllowDebugging", false);
                cp.Visit.SetProperty("AllowAdvancedEditor", false);
                cp.Visit.SetProperty("AllowEditing", false);
                // Delete the current cached file.
                cp.CdnFiles.DeleteFile("ExamplePage/ExamplePage.html");
            }
            cp.CdnFiles.Save("ExamplePage/ExamplePage.html",
                cp.Html.div("Hello world!"));

            return "";
        }
    }
}