using Microsoft.AspNetCore.Mvc;

namespace Dapper.UI.ViewComponents.HomePage
{
    public class _DefaultFeatureComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
