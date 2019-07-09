
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class BlockNewSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        { 
            // Append a hello world paragraph tag
            // to the new block. See CPBlockBaseClass
            // for more info on append.
            CPBlockBaseClass newBlock = cp.BlockNew();

            string html = cp.Html.p("Hello World!");

            newBlock.Append(html);

            // Return value is arbitrary for this
            // example because nothing needs to be 
            // explicitly returned to the user.
            return "";
        }
    }
}