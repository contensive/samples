
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CacheGetNumberSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string key = "numberCache";

            // Get the double
            double value = cp.Cache.GetNumber(key);

            // Check if the cache is empty or invalid,
            // store something if it is.
            if (value == 0)
            {
                cp.Cache.Store(key, 23.7);

                return "The cached object: " + cp.Cache.GetNumber(key);
            }
            return "The cached object: " + value;
        }
    }
}