using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class GetLayoutSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string layout = cp.Content.getLayout("defaultLayout");

            return "The layout retrieved: " + layout;
        }
    }
}
