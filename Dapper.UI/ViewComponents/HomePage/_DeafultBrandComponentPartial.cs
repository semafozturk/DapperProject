using Microsoft.AspNetCore.Mvc;

namespace Dapper.UI.ViewComponents.HomePage
{
    public class _DeafultBrandComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
