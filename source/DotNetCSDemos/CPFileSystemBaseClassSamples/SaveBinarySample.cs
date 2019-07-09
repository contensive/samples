
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class SaveBinarySample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Converting image files to a .bin file 
            // is a common usage of this method.
            string pathFilename = "SampleImage\\Image.png";
            // Ensure that the path and image exist.
            // SampleImage\Image.png is made up for 
            // the example.
            byte[] file = cp.WwwFiles.ReadBinary(pathFilename);
            
            // Do any manipulation to the binary array here
            // before it is saved to the file system.

            cp.TempFiles.SaveBinary("Sample.bin", file);

            return "";
        }
    }
}