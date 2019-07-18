using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class GetTableSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string content = "Sample Content";

            // Get the table name
            string table = cp.Content.GetTable(content);

            return content + " holds the " + 
                table + " table.";
        }
    }
}
