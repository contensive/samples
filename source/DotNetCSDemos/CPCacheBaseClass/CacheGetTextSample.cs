
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CacheGetTextSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string key = "textCache";

            // Get the text
            string value = cp.Cache.GetText(key);

            // Check if the cache is empty or invalid,
            // store something if it is.
            if (value == "")
            {
                cp.Cache.Store(key, "Hello world!");

                return "The cached text: " + cp.Cache.GetText(key);
            }
            return "The cached text: " + value;
        }
    }
}