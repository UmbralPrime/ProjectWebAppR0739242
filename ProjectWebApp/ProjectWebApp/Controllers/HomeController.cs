using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectModels;
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
        public async Task<IActionResult> Index()
        {
            ArtikelsListView vm = new ArtikelsListView();
            vm.Artikels = await _context.Artikels.ToListAsync();
            return View(vm);
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
        public async Task<IActionResult> ArtikelDetail(int id) 
        { 
            Artikel artikel = _context.Artikels.Where(p=>p.Id == id).FirstOrDefault();
            if (artikel != null)
            {
                ArtikelDetailView detailViewVm = new ArtikelDetailView()
                {
                    Artikel = artikel,
                };
                return View(detailViewVm);
            }
            else
            {
                ArtikelsListView vm = new ArtikelsListView();
                vm.Artikels = await _context.Artikels.ToListAsync();
                return View("Nieuws",vm);
            }
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
