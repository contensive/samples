
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class FileSystemAppendSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string filename = "ExampleFolder\\ExampleFile.txt";
            string fileContent = "Hello world!";

            cp.TempFiles.Append(filename, fileContent);

            return "";
        }
    }
}