using Microsoft.AspNetCore.Mvc;

namespace Dapper.UI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
