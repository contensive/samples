
using Contensive.BaseClasses;
using System;

namespace Contensive.Samples
{
    public class CSGetDateSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Create the cs object.
            CPCSBaseClass cs = cp.CSNew();

            if (cs.Open("People"))
            {
                // Get the date of the first
                // person record's last visit.
                DateTime lastVisit = 
                    cs.GetDate("lastvisit");

                cs.Close();

                return "Last visitted on: " +
                    lastVisit;
            }
            return "";
        }
    }
}