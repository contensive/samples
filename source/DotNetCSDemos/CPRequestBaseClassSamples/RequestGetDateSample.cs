
using Contensive.BaseClasses;
using System;

namespace Contensive.Samples
{
    public class RequestGetDateSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Get a made up Request property that
            // keeps track of when the page was created.
            DateTime date = cp.Request.GetDate("dateCreated");

            return "";
        }
    }
}