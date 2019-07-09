
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class FileSystemCopySample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string SourceFilename = "TestFolder\\Source.txt";
            string DestinationFileName = "TestFolder\\Destination.txt";

            cp.WwwFiles.Copy(SourceFilename, DestinationFileName, cp.TempFiles);

            return "";
        }
    }
}