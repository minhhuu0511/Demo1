using System.Web;
using System.Web.Mvc;

namespace Chieu6_Tuan3_2080600088
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
