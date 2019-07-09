
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CopyRemoteToLocalSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string pathFilename = "SamplePath\\Sample.txt";

            cp.CdnFiles.CopyRemoteToLocal(pathFilename);

            return "";
        }
    }
}