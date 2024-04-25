using Microsoft.AspNetCore.Mvc;

namespace Dapper.UI.ViewComponents.Layout
{
    public class _HeaderViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
