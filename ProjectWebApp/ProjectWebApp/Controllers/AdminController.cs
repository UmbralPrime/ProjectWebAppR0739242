using Microsoft.AspNetCore.Mvc;

namespace ProjectWebApp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Leden()
        {
            return View();
        }
    }
}
