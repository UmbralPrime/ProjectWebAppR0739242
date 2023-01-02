using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectModels;
using ProjectWebApp.ViewModel;
using System.Drawing;

namespace ProjectWebApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly ProjectDBContext _context;
        public AdminController(ProjectDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Leden()
        {
            LedenListView vm = new LedenListView();
            vm.Leden = await _context.Leden.ToListAsync();
            return View(vm);
        }
        [HttpGet]
        public async Task<IActionResult> CreateLid()
        {
            LidUpdateCreateView vm = new LidUpdateCreateView();
            vm.AlleGroepen = (ICollection<Groep>)_context.Groepen.ToListAsync();
            return View(vm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateLid(LidUpdateCreateView vm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(new Lid()
                {
                    Naam = vm.Naam,
                    Voornaam = vm.Voornaam,
                    Email = vm.Email,
                    IsOuder = vm.IsOuder,
                    Betaald = vm.Betaald,
                    Telefoon = vm.Telefoon,
                    Geboortedatum = vm.Geboortedatum,
                    Groep = vm.Groep
                });
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Leden));
            }
            return View(vm);

        }
        [HttpGet]
        public async Task<IActionResult> DeleteLid(int id)
        {
            Lid lid = _context.Leden.Where(l => l.Id == id).FirstOrDefault();
            if (lid != null)
            {
                LidDeleteView vm = new LidDeleteView()
                {
                    Id = id,
                    Naam = lid.Naam,
                    Voornaam = lid.Voornaam,
                    Email = lid.Email,
                    IsOuder = lid.IsOuder,
                    Betaald = lid.Betaald,
                    Telefoon = lid.Telefoon,
                    Geboortedatum = lid.Geboortedatum,
                    Groep = lid.Groep
                };
                return View(vm);
            }
            else
            {
                LedenListView vm = new LedenListView()
                {
                    Leden = _context.Leden.ToList()
                };
                return View("Leden", vm);
            }
        }
        [HttpGet]
        public async Task<IActionResult> UpdateLid(int? id)
        {
            if (id == null)
                return NotFound();
            Lid lid = _context.Leden.Where(x => x.Id == id).FirstOrDefault();
            if (lid == null) return NotFound();
            LidUpdateCreateView vm = new LidUpdateCreateView()
            {
                Naam = lid.Naam,
                Voornaam = lid.Voornaam,
                Email = lid.Email,
                IsOuder = lid.IsOuder,
                Betaald = lid.Betaald,
                Telefoon = lid.Telefoon,
                Geboortedatum = lid.Geboortedatum,
                Groep = lid.Groep,
                AlleGroepen = _context.Groepen.ToList()
            };
            return View(vm);
        }
        [HttpGet]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateLid(int id, LidUpdateCreateView vm)
        {
            if (id != vm.Id)
                return NotFound();
            if (ModelState.IsValid)
            {
                try
                {
                    Lid lid = new Lid()
                    {
                        Naam = vm.Naam,
                        Voornaam = vm.Voornaam,
                        Email = vm.Email,
                        IsOuder = vm.IsOuder,
                        Betaald = vm.Betaald,
                        Telefoon = vm.Telefoon,
                        Geboortedatum = vm.Geboortedatum,
                        Groep = vm.Groep
                    };
                    _context.Update(lid);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException e)
                {
                    if (!_context.Leden.Any(x => x.Id == vm.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Leden));
            }
            return View(vm);
        }
    }
}

