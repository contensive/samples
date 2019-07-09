
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class AddLinkAliasSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string linkAlias = "";
            int pageId = cp.Doc.PageId;
            string queryStringSuffix = "";

            cp.Site.AddLinkAlias(linkAlias, pageId, queryStringSuffix);

            return "";
        }
    }
}