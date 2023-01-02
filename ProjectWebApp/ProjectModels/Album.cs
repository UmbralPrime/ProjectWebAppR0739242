using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectModels
{
    public class Album
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Titel { get; set; }
        [Required]
        public DateTime Datum { get; set; }
        public List<Afbeelding> Afbeeldingen { get; set; }
    }
}
