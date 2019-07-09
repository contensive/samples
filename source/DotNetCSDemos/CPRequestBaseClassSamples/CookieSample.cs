
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CookieSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Get the Visit cookie belonging
            // to contensive.io
            string cookie = cp.Request.Cookie("ciovisit");

            return "something";
        }
    }
}