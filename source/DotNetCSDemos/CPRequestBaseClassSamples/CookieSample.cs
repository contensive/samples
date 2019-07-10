
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CookieSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // Get the a cookie that
            // has your birthday.
            string birthday = cp.Request.Cookie("birthday");

            return birthday;
        }
    }
}