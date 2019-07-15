
using Contensive.BaseClasses;
using System.Collections.Generic;

namespace Contensive.Samples
{
    public class CacheGetGenericObjectSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string key = "genericCache";

            // Get the cached list of strings.
            object value = cp.Cache.GetObject<List<string>>(key);

            // Check if the cache is empty or invalid,
            // store something if it is.
            if (value == null)
            {
                // Make a list of animals to cache.
                List<string> animals = new List<string>();
                animals.Add("dog");
                animals.Add("cat");
                animals.Add("fish");

                // Store the list.
                cp.Cache.Store(key, animals);

                string retVal = "";

                // Read the list of animals into a string.
                foreach(string s in cp.Cache.GetObject<List<string>>(key))
                {
                    retVal += s + "<br>";
                }
                return "The cached objects:<br>" + retVal;
            }
            return "The cached objects:<br>" + value;
        }
    }
}