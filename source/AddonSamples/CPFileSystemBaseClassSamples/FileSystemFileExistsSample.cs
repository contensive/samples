
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class FileSystemFileExistsSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string Filename = "sample.txt";
            string file = "";

             if (cp.CdnFiles.FileExists(Filename))
             {
                file = cp.CdnFiles.Read(Filename);
             }
            return file;
        }
    }
}