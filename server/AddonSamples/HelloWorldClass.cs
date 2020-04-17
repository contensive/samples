
using Contensive.BaseClasses;

namespace Contensive.Samples {
    public class HelloWorldClass : AddonBaseClass {
        public override object Execute(CPBaseClass CP) {
            return "Hello World";
        }
    }
}
