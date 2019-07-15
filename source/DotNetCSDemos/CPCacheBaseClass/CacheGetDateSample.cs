
using Contensive.BaseClasses;
using System;

namespace Contensive.Samples
{
    public class CacheGetDateSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string key = "dateCache";

            // Get the DateTime value
            DateTime value = cp.Cache.GetDate(key);

            // Check if the cache is empty or does
            // not store today's date. Store 
            // today's date if true.
            if (value != DateTime.Now || value == DateTime.MinValue)
            {
                cp.Cache.Store(key, DateTime.Now);

                return "Today's date: " + cp.Cache.GetDate(key);
            }
            return "Today's date: " + value;
        }
    }
}