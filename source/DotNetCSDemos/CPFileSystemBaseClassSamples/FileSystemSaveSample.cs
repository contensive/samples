
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class FileSystemSaveSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Given path in 'pathFilename' will be
            // created upon saving if it does not 
            // already exist.
            string pathFilename = "TestPath\\Text.txt";
            string fileContent = "Hello world!";

            cp.TempFiles.Save(pathFilename, fileContent);

            return "";
        }
    }
}