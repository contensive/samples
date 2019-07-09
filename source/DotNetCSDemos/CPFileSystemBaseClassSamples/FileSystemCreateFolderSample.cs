
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class FileSystemCreateFolderSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string FolderPath = "TestPath\\ExamplePath";

            cp.PrivateFiles.CreateFolder(FolderPath);

            return "";
        }
    }
}