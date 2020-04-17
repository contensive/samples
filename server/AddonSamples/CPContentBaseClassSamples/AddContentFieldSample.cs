using Contensive.BaseClasses;

namespace Contensive.Samples {
    public class AddContentFieldSample : AddonBaseClass {
        public override object Execute(CPBaseClass cp) {
            string content = "Sample Content";
            string fieldName = "SampleId";
            // See fileTypeIdEnum for info on different types.
            int newFieldId = cp.Content.AddContentField(content, fieldName, CPContentBaseClass.FieldTypeIdEnum.Integer);
            return fieldName + " ID#" + newFieldId + " is the new field in " + content;
        }
    }
}
