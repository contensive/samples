
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CacheInvalidateAllSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Invalidate all system cache.
            cp.Cache.InvalidateAll();

            return "";
        }
    }
}