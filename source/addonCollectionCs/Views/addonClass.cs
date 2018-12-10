

using System;
using System.Collections.Generic;
using System.Text;
using Contensive.BaseClasses;

namespace Contensive.Addons.AddonCollectionCs {
    namespace Views {
        //
        // ====================================================================================================
        /// <summary>
        /// This class can be called from a Contnesive add-on by adding the namespace.classname to the Dotnot field in the Code tab.
        /// In this sample, the Dotnet field would be "Contensive.Addons.AddonCollectionCs.Views.AddonClass"
        /// </summary>
        public class AddonClass : AddonBaseClass {
            //
            // ====================================================================================================
            /// <summary>
            /// The execute method is called from Contensive and it passes the cp argument to this method. The method returns an object which is typically a string.
            /// 
            /// </summary>
            /// <param name="cp"></param>
            /// <returns></returns>
            public override object Execute(CPBaseClass cp) {
                string result = "";
                try {
                    //
                    // your code here
                    //
                    result = "Hello World";
                } catch (Exception ex) {
                    cp.Site.ErrorReport(ex);
                    //
                    // -- the execute method would typically not throw an error into the consuming method. Log and return.
                    result = "Error Response";
                }
                return result;
            }
        }
    }
}
