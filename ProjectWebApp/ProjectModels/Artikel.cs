using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectModels
{
    public class Artikel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Titel { get; set; }
        [Required]
        public string Inhoud { get; set; }
        [Required]
        public DateTime Datum { get; set; }
        public ICollection<ArtikelGroep> Groepen { get; set; }
    }
}
