
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class SameFileSystemCopySample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // 'Source.txt' stays the same, but the 
            // destination directory changes.
            string SourceFilename = "TestFolder\\Source.txt";
            string DestinationFilename = "SampleFolder\\Source.txt";

            // In CdnFiles, copy 'Source.txt' from 'TestFolder' 
            // to 'SampleFolder'. The copied file will remain
            // in CdnFiles.
            cp.CdnFiles.Copy(SourceFilename, DestinationFilename);

            return "";
        }
    }
}