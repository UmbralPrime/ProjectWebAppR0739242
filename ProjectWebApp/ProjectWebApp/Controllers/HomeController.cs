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
        public async Task<IActionResult> Foto()
        {
            AlbumListView vm = new AlbumListView();
            vm.Albums = await _context.Albums.Include(p=>p.Afbeeldingen).ToListAsync(); 
            return View(vm);
        }
        [Authorize]
        public async Task<IActionResult> FotoAlbum(int id)
        {
            Album album = _context.Albums.Where(p => p.Id == id).Include(p=>p.Afbeeldingen).FirstOrDefault();
            if(album != null)
            {
                FotoListView vm = new FotoListView()
                {
                    Album= album,
                    Afbeeldingen= album.Afbeeldingen
                };
                return View(vm);
            }
            else
            {
                AlbumListView vm = new AlbumListView();
                vm.Albums = await _context.Albums.ToListAsync();
                return View("Foto", vm);
            }            
        }
        public async Task<IActionResult> Kalender() 
        {
            KalenderListView vm = new KalenderListView();
            vm.Activiteiten = await _context.Activiteit.Where(p=>p.Datum >=DateTime.Now).OrderBy(x => x.Datum).ToListAsync();
            return View(vm);
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
