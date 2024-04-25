using Microsoft.AspNetCore.Mvc;

namespace Dapper.UI.ViewComponents.HomePage
{
    public class _DefaultFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
