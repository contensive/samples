
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class FileSystemDeleteFolderSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string folderPath = "SamplePath\\ExamplePath";

            cp.WwwFiles.DeleteFolder(folderPath);

            return "";
        }
    }
}