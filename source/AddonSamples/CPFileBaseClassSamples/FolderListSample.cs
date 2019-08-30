
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class FolderListSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string folderName = "ExamplePath";

            string list = ""; // cp.File.folderList(folderName);

            return list;
        }
    }
}