using System.Web;
using System.Web.Mvc;

namespace ProductCatalog_PRACTIAL_6
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
