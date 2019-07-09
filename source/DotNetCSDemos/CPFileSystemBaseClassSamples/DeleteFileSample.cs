
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class DeleteFileSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string pathFilename = "sample.txt";

            if(cp.CdnFiles.FileExists(pathFilename))
            {
                cp.CdnFiles.DeleteFile(pathFilename);
            }
            return "";
        }
    }
}