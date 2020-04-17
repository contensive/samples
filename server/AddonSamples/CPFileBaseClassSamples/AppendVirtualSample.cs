
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class AppendVirtualSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string Filename = "ExampleFolder\\ExampleFile.txt";
            string fileContent = "Hello world!";
            return "";
        }
    }
}