
using Contensive.BaseClasses;

namespace MyNameSpace {
    public class CPVersionClass : AddonBaseClass {
        public override object Execute(CPBaseClass cp) {
            return "The version of CP is " + cp.Version;
        }
    }
}