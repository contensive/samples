using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class DocGetPropertySample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Prompt user to search for the 
            // name of a blog post
            string key = "blogPostSearch";

            string temp = cp.Doc.GetProperty(key);

            // Return value is arbitrary for this
            // example because nothing needs to be 
            // explicitly returned to the user.
            return "";
        }
    }
}
