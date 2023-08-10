using System.Web;
using System.Web.Mvc;

namespace Kiandra_FA2_SLD521_ComicBookStore
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
