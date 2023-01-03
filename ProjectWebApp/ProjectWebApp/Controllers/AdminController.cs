using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectModels;
using ProjectWebApp.Areas.Identity.Data;
using ProjectWebApp.ViewModel;
using System.Data;
using System.Drawing;

namespace ProjectWebApp.Controllers
{
    
    public class AdminController : Controller
    {
        private readonly ProjectDBContext _context;
        private UserManager<CustomUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        public AdminController(UserManager<CustomUser> userManager, RoleManager<IdentityRole> roleManager, ProjectDBContext context)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Leden()
        {
            CustomUser user = await _userManager.GetUserAsync(User);
            IdentityRole role = await _roleManager.FindByNameAsync("admin");

            IdentityResult result = await _userManager.AddToRoleAsync(user, role.Name);
            LedenListView vm = new LedenListView();
            vm.Leden = await _context.Leden.ToListAsync();
            return View(vm);
        }
        public IActionResult Gebruikers()
        {
            GebruikersListView vm = new GebruikersListView() 
            {
                Gebruikers = _userManager.Users.ToList()
            };
            return View(vm);
        }
        [HttpGet]
        public async Task<IActionResult> CreateLid()
        {
            LidUpdateCreateView vm = new LidUpdateCreateView();
            vm.AlleGroepen = new SelectList(_context.Groepen.ToList(), "Id", "Naam");
            vm.Geboortedatum = DateTime.Now.Date;
            return View(vm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateLid(LidUpdateCreateView vm)
        {
            ModelState["AlleGroepen"].ValidationState = Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Valid;
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
                    GroepId = vm.GroepId
                });
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Leden));
            }
            else
            {
                vm.AlleGroepen = new SelectList(_context.Groepen.ToList(), "Id", "Naam");
                return View(vm);
            }


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
                    Geboortedatum = lid.Geboortedatum
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
                AlleGroepen = new SelectList(_context.Groepen.ToList(), "Id", "Naam")
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
                        Geboortedatum = vm.Geboortedatum
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

