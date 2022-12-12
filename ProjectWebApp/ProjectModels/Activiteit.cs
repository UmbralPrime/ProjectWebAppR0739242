using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectModels
{
    public class Activiteit
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "De ingevulde naam is te lang. Maximale lengte is 50.")]
        public string Naam { get; set; }
        [Required]
        public string Beschrijving { get; set; }
        public ICollection<ActiviteitGroep> Groepen { get; set; }

    }
}
