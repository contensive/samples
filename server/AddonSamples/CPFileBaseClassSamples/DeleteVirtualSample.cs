
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class DeleteVirtualSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string Filename = "sample.txt";

            //if(cp.File.fileExists(Filename))
            //{
                // cp.File.DeleteVirtual(Filename);
            //}
            return "";
        }
    }
}