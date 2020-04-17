
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class FileSaveSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string Filename = "TestPath\\Text.txt";
            string FileContent = "Hello world!";

            // cp.File.Save(Filename, FileContent);

            return "";
        }
    }
}