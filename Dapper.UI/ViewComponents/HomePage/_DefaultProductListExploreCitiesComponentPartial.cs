using Microsoft.AspNetCore.Mvc;

namespace Dapper.UI.ViewComponents.HomePage
{
    public class _DefaultProductListExploreCitiesComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
