
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CSGetAddLinkSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Create the cs object.
            CPCSBaseClass cs = cp.CSNew();

            if (cs.Open("People"))
            {
                // Get an add record link to
                // to 'People'
                string addLink = cs.GetAddLink();

                cs.Close();

                return "Add a people record: " + addLink;
            }
            return "";
        }
    }
}