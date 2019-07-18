
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CacheGetBooleanSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string key = "booleanCache";

            // Get the double value
            bool value = cp.Cache.GetBoolean(key);

            // Check if the cache is empty or invalid,
            // store something if it is.
            if (value == false)
            {
                cp.Cache.Store(key, true);

                return "The cached boolean: " + cp.Cache.GetBoolean(key);
            }
            return "The cached boolean: " + value;
        }
    }
}