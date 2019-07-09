
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CopyVirtualSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string SourceFilename = "TestFolder\\Source.txt";
            string DestinationFileName = "TestFolder\\Destination.txt";

            // cp.File.CopyVirtual(SourceFilename, DestinationFileName);

            return "";
        }
    }
}