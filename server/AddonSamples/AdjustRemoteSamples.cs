
using Contensive.BaseClasses;
using System.Collections.Generic;

namespace Contensive.Samples
{
    public class AdjustRemoteSamples : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // List of samples that have the run button hidden.
            List<string> names = new List<string>();

            CPCSBaseClass cs = cp.CSNew();

            // Open a record set containing the names of 
            // every sample with the run button hidden.
            if(cs.Open("API Page Object Examples", "(hiderunbutton=1)", "name", true, "name"))
            {
                // Loop through the list.
                while(cs.OK())
                {
                    // Add the names to the list.
                    names.Add(cs.GetText("name"));
                    cs.GoNext();
                }
                cs.Close();
            }

            int samplesId = cp.Content.GetRecordID("Add-on Collections", "CPBaseClassSamples");

            // Open the Content containing the add-on samples.
            if(cs.Open("Add-ons", "(collectionid=" + samplesId + ")"))
            {
                // Loop through the list.
                while (cs.OK())
                {
                    // If the current add-on is in our list
                    // of names, turn off the remote functionality.
                    if(names.Contains(cs.GetText("name")))
                    {
                        cs.SetField("remotemethod", false);
                    }
                    cs.GoNext();
                }
                cs.Close();
            } 

            return "";
        }
    }
}