
using Contensive.BaseClasses;
using System;

namespace Contensive.Samples
{
    public class VisitGetDateSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Made up Visit property that stores the date of
            // the first hit to the application.
            DateTime firstHitDate = cp.Visit.GetDate("firstHit");

            return "The date of the first hit was " + firstHitDate;
        }
    }
}