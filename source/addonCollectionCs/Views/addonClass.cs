

using System;
using Contensive.BaseClasses;

namespace Samples.AddonCollectionCs {
    namespace Views {
        //
        public class AddonClass : AddonBaseClass {
            //
            public override object Execute(CPBaseClass cp) {
                string result = "";
                try {
                    //
                    // code here
                    //
                    return "Hello World";
                } catch (Exception ex) {
                    //
                    // -- the execute method should typically not throw an error into the consuming method. Log and return.
                    cp.Site.ErrorReport(ex);
                    result = "Error Response";
                }
                return result;
            }
        }
    }
}
