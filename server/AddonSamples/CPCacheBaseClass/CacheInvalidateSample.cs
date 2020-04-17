
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CacheInvalidateSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string key = "sampleKey";

            // Invalidate a made up cached object.
            cp.Cache.Invalidate(key);

            return "";
        }
    }
}