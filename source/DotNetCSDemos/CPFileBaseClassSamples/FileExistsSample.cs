
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class FileExistsSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string Filename = "sample.txt";
            string file = "";

            // if (cp.File.fileExists(Filename))
            // {
               // file = cp.File.Read(Filename);
            // }
            return file;
        }
    }
}