using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectWebApp.Models;
using System.Diagnostics;

namespace ProjectWebApp.Controllers
{
    public class HomeController:Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        [Authorize]
        public IActionResult Foto()
        {
            return View();
        }
        public IActionResult Kalender() 
        {
            return View();
        }
        public IActionResult Nieuws()
        {
            return View();
        }
        public IActionResult Rescue()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
