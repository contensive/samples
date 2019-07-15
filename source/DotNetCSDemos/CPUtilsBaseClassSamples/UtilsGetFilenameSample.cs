
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class UtilsGetFilenameSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string pathFilename = "SamplePath\\example.txt";
            string filename = cp.Utils.GetFilename(pathFilename);

            return "The filename is: " + filename;
        }
    }
}