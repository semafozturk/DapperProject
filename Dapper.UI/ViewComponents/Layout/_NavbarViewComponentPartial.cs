using Microsoft.AspNetCore.Mvc;

namespace Dapper.UI.ViewComponents.Layout
{
    public class _NavbarViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
