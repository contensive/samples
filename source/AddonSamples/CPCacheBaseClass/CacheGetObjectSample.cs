
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CacheGetObjectSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string key = "objectCache";

            // Get the object
            object value = cp.Cache.GetObject(key);

            // Check if the cache is empty or invalid,
            // store something if it is.
            if(value == null)
            {
                cp.Cache.Store(key, 5.4);

                return "The cached object: " + cp.Cache.GetObject(key);
            }
            return "The cached object: " + value;
        }
    }
}