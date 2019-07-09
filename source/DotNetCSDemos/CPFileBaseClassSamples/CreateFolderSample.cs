
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CreateFolderSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string FolderPath = "TestPath\\ExamplePath";

            // cp.File.CreateFolder(FolderPath);

            return "";
        }
    }
}