using Microsoft.AspNetCore.Mvc;

namespace Dapper.UI.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
