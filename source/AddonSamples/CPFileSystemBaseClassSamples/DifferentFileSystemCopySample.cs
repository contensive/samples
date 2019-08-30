
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class DifferentFileSystemCopySample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Source name/destination are the same, but
            // the destination will be a different file system.
            string SourceFilename = "TestFolder\\Source.txt";
            string DestinationFileName = "TestFolder\\Source.txt";

            // The destination is in the temp file system.
            CPFileSystemBaseClass destinationFileSystem = cp.TempFiles;

            // Copy the file from the WWW file system to the
            // temp file system.
            cp.WwwFiles.Copy(SourceFilename, DestinationFileName, 
                destinationFileSystem);

            return "";
        }
    }
}