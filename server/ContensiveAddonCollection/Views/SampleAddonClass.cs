
using System;
using Contensive.Addons.AddonSamples.Controllers;
using Contensive.BaseClasses;

namespace Contensive.Addons.AddonSamples {
    namespace Views {
        //
        public class SampleAddonClass : AddonBaseClass {
            //
            public override object Execute(CPBaseClass cp) {
                try {
                    //
                    // -- code here
                    return "Hello World";
                } catch (Exception ex) {
                    //
                    // -- the execute method should typically not throw an error into the consuming method. Log and return.
                    cp.Site.ErrorReport(ex);
                    return string.Empty;
                }
            }
        }
    }
}
