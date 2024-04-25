using Microsoft.AspNetCore.Mvc;

namespace Dapper.UI.ViewComponents.HomePage
{
    public class _DeafultHomePageProductList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
