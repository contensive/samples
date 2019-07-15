
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CacheGetIntegerSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string key = "intCache";

            // Get the integer
            int value = cp.Cache.GetInteger(key);

            // Check if the cache is empty or invalid,
            // store something if it is.
            if (value == 0)
            {
                cp.Cache.Store(key, 1337);

                return "The cached integer: " + cp.Cache.GetInteger(key);
            }
            return "The cached integer: " + value;
        }
    }
}