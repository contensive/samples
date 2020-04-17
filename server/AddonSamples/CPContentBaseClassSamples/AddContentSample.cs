using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class AddContentSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string ContentName = "Example Content";
            string sqlTableName = "exampleContent";
            string dataSource = "default";

            cp.Content.AddContent(ContentName, sqlTableName, dataSource);

            // Return value is arbitrary for this
            // example because nothing needs to be 
            // explicitly returned to the user.
            return "";
        }
    }
}
