
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CacheClearAllSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Invalidate all system cache.
            cp.Cache.ClearAll();

            return "";
        }
    }
}