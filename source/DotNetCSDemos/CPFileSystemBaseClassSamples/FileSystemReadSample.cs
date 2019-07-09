
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class FileSystemReadSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string sample = "";
            // Ensure that the file exists before it is read.
            if (cp.CdnFiles.FileExists("ExamplePath\\sample.txt"))
            { 
                sample = cp.CdnFiles.Read("ExamplePath\\sample.txt");
            }

            // Manipulate the text file here before returning it.

            return sample;
        }
    }
}