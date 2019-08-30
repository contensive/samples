using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class AddContentFieldSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string content = "Sample Content";
            string fieldName = "Sample ID";

            // See fileTypeIdEnum for info on different types.
            int newFieldId = cp.Content.AddContentField(content, fieldName,
                CPContentBaseClass.fileTypeIdEnum.Integer);

            return fieldName + " ID#" + newFieldId + " is the new field in " +
                content;
        }
    }
}
