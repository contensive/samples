
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class FileSystemFolderExistsSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string folderName = "SamplePath\\ExamplePath";

            if (cp.WwwFiles.FolderExists(folderName))
            {
            return folderName + " exists.";
            }
            else
            {
            return folderName + " does not exist.";
            }
        }
    }
}