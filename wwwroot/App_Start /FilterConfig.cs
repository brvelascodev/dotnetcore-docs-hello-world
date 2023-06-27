using System.Web;
using System.Web.Mvc;

namespace test-app-load //Namespace will vary based on project name
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new ErrorHandler.AiHandleErrorAttribute());
        }
    }
}
