using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class GetDataSourceSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Get the data source.
            string DS = cp.Content.GetDataSource("Sample Content");

            return "Sample Content belongs to the " +
                DS + " data source.";
        }
    }
}
