using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class GetTableIDSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Get the table ID of the table
            // linked to 'Sample Content'
            int tableID = cp.Content.GetTableID(
                "sampleContent");

            return "The table ID is #" + tableID;
        }
    }
}
