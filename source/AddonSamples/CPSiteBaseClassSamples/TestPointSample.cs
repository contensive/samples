
using Contensive.BaseClasses;
using System;

namespace Contensive.Samples
{
    public class TestPointSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            cp.Site.TestPoint("Test point was hit at" +
                DateTime.Now);

            return "";
        }
    }
}