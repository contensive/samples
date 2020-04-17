using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class ContentGetIDSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            int ID = cp.Content.GetID("Sample Content");

            return "#" + ID + " Sample Content";
        }
    }
}
