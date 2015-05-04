using System.Web;
using System.Web.Mvc;

namespace MvcApplication1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}C:\Users\user\Desktop\KuasWebApp\MvcApplication1\App_Start\FilterConfig.cs