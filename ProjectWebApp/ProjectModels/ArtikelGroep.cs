using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectModels
{
    public class ArtikelGroep
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int GroepId { get; set; }
        [Required]
        public int ArtikelId { get; set; }
        public Groep Groep { get; set; }
        public Artikel Artikel { get; set; }
    }
}
