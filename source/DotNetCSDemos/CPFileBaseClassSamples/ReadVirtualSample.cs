
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class ReadVirtualSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string file = ""; // cp.File.ReadVirtual("VirtualPath\\Sample.txt");

            return file;
        }
    }
}