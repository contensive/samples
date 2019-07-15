
using Contensive.BaseClasses;
using System.Collections.Generic;

namespace Contensive.Samples
{
    public class CacheClearSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Create a keyList containing multiple
            // made up keys that would reference
            // cached objects.
            List<string> keyList = new List<string>();
            keyList.Add("sampleKey1");
            keyList.Add("sampleKey2");

            // Invalidate the made up cached objects.
            cp.Cache.Clear(keyList);

            return "";
        }
    }
}