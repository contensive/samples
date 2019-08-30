
using Contensive.BaseClasses;
using System;
using System.Collections.Generic;

namespace Contensive.Samples
{
    public class ErrorReportSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Add to a null list to force a
            // NullReferenceException as an example.
            List<int> temp = null;
            try
            {
                temp.Add(1);
            } catch (NullReferenceException Ex)
            {
                cp.Site.ErrorReport(Ex, "Property" +
                    " is null.");
              // Catching Exception at the end is useful
              // for handling unanticipated errors.
            } catch(Exception Ex)
            {
                cp.Site.ErrorReport(Ex, "Error occurred.");
            }
            return "";
        }
    }
}