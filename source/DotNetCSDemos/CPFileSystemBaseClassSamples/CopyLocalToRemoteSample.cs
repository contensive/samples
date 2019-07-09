
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CopyLocalToRemoteSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string pathFilename = "SamplePath\\Sample.txt";

            cp.WwwFiles.CopyLocalToRemote(pathFilename);

            return "";
        }
    }
}