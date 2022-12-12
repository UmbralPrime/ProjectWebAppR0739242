using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectModels
{
    public class Lid
    {
        [Key]
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
        public ICollection<LidGroep> Groep { get; set; }
    }
}
