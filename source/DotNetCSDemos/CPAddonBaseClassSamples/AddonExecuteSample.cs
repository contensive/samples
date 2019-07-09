
using Contensive.BaseClasses;
using System.Collections.Generic;

namespace Contensive.Samples
{
    public class AddonExecuteSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            int addonId = 45;

            Dictionary<string, string> argumentKeyValuePairs
                = new Dictionary<string, string>();

            argumentKeyValuePairs.Add("Type", "Simple");
            argumentKeyValuePairs.Add("NoFollow", "true");

            // Return the output of the addon after execution.
            return cp.Addon.Execute(addonId, argumentKeyValuePairs);
        }
    }
}