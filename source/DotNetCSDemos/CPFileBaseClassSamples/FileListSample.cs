
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class FileListSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string folderName = "SamplePath";

            string list = ""; // cp.File.fileList(folderName);

            return list;
        }
    }
}