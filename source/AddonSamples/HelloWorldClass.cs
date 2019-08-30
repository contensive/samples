
using Contensive.BaseClasses;

namespace Contensive.Samples {
    class HelloWorldClass : AddonBaseClass {
        public override object Execute(CPBaseClass CP) {
            return "Hello World";
        }
    }
}
