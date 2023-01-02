using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectModels
{
    public class Groep
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Naam { get; set; }
        public ICollection<ActiviteitGroep> Activiteiten { get; set; }
        public ICollection<Lid> Leden { get; set; }
        public ICollection<ArtikelGroep> Artikels { get; set; }
    }
}
