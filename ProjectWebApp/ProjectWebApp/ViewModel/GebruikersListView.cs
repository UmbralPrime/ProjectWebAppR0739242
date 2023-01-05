using Microsoft.AspNetCore.Identity;
using ProjectWebApp.Areas.Identity.Data;

namespace ProjectWebApp.ViewModel
{
    public class GebruikersListView
    {
        public List<CustomUser> Gebruikers { get; set; }
        public UserManager<CustomUser> UserManager;
        public RoleManager<IdentityRole> RoleManager;
    }
}
