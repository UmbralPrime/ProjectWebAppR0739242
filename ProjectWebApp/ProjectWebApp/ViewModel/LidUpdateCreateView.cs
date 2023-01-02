using ProjectModels;
using System.ComponentModel.DataAnnotations;

namespace ProjectWebApp.ViewModel
{
    public class LidUpdateCreateView
    {
        public int Id { get; set; }
        [Required]
        public string Naam { get; set; }
        [Required]
        public string Voornaam { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public bool IsOuder { get; set; }
        [Required]
        public bool Betaald { get; set; }
        [Required]
        public string Telefoon { get; set; }
        [Required]
        public DateTime Geboortedatum { get; set; }
        public Groep Groep { get; set; }
        public ICollection<Groep> AlleGroepen { get; set; }
    }
}
