using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectModels
{
    public class Agenda
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Datum { get; set; }
        [Required]
        public int ActiviteitGroepId { get; set; }
        public ActiviteitGroep ActiviteitGroep { get; set; }        
    }
}
