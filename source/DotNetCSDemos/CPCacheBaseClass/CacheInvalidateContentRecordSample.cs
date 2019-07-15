
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CacheInvalidateContentRecordSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            int recordId = 2;
            string contentName = "Sample Content";

            // Invalidate a cached record in the "Sample Content"
            // content table.
            cp.Cache.InvalidateContentRecord(contentName,
                recordId);

            return "";
        }
    }
}