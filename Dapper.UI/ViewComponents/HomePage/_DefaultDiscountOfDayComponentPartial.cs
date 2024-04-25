using Microsoft.AspNetCore.Mvc;

namespace Dapper.UI.ViewComponents.HomePage
{
    public class _DefaultDiscountOfDayComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
