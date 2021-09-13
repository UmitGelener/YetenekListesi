using System.Web;
using System.Web.Mvc;

namespace Skill_CodeFirstEntityProject
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
