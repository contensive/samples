
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class Html5CheckListSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            string htmlName = "memberCheckList";

            // This is the content table we want to
            // act as our primary table. 
            string primaryContentName = "People";

            // The user will check on groups 
            // in the checklist they belong to.
            int primaryRecordId = cp.User.Id;

            // Each record in the 'Groups' 
            // content table will appear in the 
            // checklist.
            string secondaryContentName = "Groups";

            // The rules content table that exists
            // between both 'Groups' and 'People'. 
            // It has two fields that hold the 
            // primary content records and the 
            // secondary content records. 
            string rulesContentName = "Member Rules";
            string rulesPrimaryFieldName = "memberId";
            string rulesSecondaryFieldName = "groupId";

            // Add everything to the checkList
            string checkList = cp.Html5.CheckList(htmlName, 
                primaryContentName, primaryRecordId, 
                secondaryContentName, rulesContentName, 
                rulesPrimaryFieldName, rulesSecondaryFieldName);

            // Make a submit button
            string button = cp.Html5.Button("button", "Submit");

            // Add the checklist and submit button to the form.
            string innerHtml = "Select the groups you want to " +
                "be in:<br>" + checkList + "<br><br>" + button;

            string form = cp.Html5.Form(innerHtml);

            // Check if the user clicked the submit button.
            if (cp.Doc.GetText("button").Equals("Submit"))
            {
                cp.Html5.ProcessCheckList(htmlName, primaryContentName,
                    primaryRecordId.ToString(), secondaryContentName, rulesContentName,
                    rulesPrimaryFieldName, rulesSecondaryFieldName);

                return form + "Thank you";
            }
            // Return the initial form.
            return form;
        }
    }
}