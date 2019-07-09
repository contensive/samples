
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class SaveUploadSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // This is the name attribute that acts as the 
            // key to access the uploaded file.
            string htmlFormName = "inputFile";

            // Use our form name for the actual file input box.
            string fileInput = cp.Html5.InputFile(htmlFormName);
            string submitButton = cp.Html5.Button("button", "Submit");

            // Put both the input file box and the submit button inside
            // the form.
            string innerHtml = fileInput + "<br><br>" + 
                submitButton + "<br>";
            string form = cp.Html5.Form(innerHtml);

            // String that will hold the name of the file that 
            // is uploaded.
            string returnFilename = "";

            // If the user presses the submit button... 
            // The value of 'button' will be set to 
            // 'Submit' if it is clicked.
            if (cp.Doc.GetText("button").Equals("Submit"))
            {
                // Using the call to SaveUpload as a conditional
                // handles the case in which no file is 
                // inputted before clicking the 'Submit' button.
                if (cp.TempFiles.SaveUpload(htmlFormName, 
                    ref returnFilename))
                {
                    return form + "Upload of the following file " +
                        "was successful: " + returnFilename;
                }
            }
            // Return the form at first. The above conditional
            // will be executed again once a file is inputted 
            // and the 'Submit' button is clicked.
            return form;
        }
    }
}