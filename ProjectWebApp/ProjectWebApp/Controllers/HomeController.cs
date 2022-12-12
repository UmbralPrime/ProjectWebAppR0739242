using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectWebApp.Models;
using ProjectWebApp.ViewModel;
using System.Diagnostics;

namespace ProjectWebApp.Controllers
{
    public class HomeController:Controller
    {
        private readonly ProjectDBContext _context;
        public HomeController(ProjectDBContext context)
        {
            _context= context;
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
        public async Task<IActionResult> Nieuws()
        {
            ArtikelsListView vm = new ArtikelsListView();
            vm.Artikels = await _context.Artikels.ToListAsync();
            return View(vm);
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
