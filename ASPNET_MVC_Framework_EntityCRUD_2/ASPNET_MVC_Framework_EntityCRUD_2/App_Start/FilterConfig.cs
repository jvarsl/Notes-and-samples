using System.Web;
using System.Web.Mvc;

namespace ASPNET_MVC_Framework_EntityCRUD_2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
