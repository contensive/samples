
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class DeleteFolderSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string folderPath = "SamplePath\\ExamplePath";

            // cp.File.DeleteFolder(folderPath);

            return "";
        }
    }
}