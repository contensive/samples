
using Contensive.BaseClasses;
using System.Collections.Generic;

namespace Contensive.Samples
{
    public class FileSystemFileListSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string folderName = "SamplePath";

            List<CPFileSystemBaseClass.FileDetail> list = cp.PrivateFiles.FileList(folderName);

            return "";
        }
    }
}