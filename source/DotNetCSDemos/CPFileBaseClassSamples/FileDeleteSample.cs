
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class FileDeleteSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string Filename = "sample.txt";
            // if(cp.File.fileExists(Filename))
            // {
                // cp.File.Delete(Filename);
            // }
            return "";
        }
    }
}