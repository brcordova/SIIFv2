using System.Web;
using System.Web.Mvc;

namespace SIIFv2_1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        }
    }
}
