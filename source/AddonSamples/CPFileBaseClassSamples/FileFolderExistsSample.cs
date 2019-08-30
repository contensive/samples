
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class FileFolderExistsSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string folderName = "SamplePath\\ExamplePath";

            //if (cp.File.folderExists(folderName))
            //{
                //return folderName + " exists.";
            //}
            //else
            //{
                return folderName + " does not exist.";
            //}
        }
    }
}