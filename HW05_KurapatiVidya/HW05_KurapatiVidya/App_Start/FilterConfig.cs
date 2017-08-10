using System.Web;
using System.Web.Mvc;

namespace HW05_KurapatiVidya
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
