
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class ContentIsFieldSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string ContentName = "Sample Content";
            string FieldName = "name";

            if(cp.Content.IsField(ContentName, FieldName)) {
                return FieldName + " is a field in " +
                    ContentName;
            } else
            {
                return FieldName + " is a field in " +
                    ContentName;
            }
        }
    }
}