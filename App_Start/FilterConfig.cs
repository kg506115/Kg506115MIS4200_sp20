using System.Web;
using System.Web.Mvc;

namespace Kg506115MIS4200_sp20
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
