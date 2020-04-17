
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class FileSaveVirtualSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string Filename = "TestPath\\Text.txt";
            string FileContent = "Hello world!";

            // cp.File.SaveVirtual(Filename, FileContent);

            return "";
        }
    }
}