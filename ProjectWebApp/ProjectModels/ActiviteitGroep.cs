using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectModels
{
    public class ActiviteitGroep
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ActiviteitId { get; set; }
        [Required]
        public int GroepId { get; set; }
        public Groep Groep { get; set; }
        public Activiteit Activiteit { get; set; }
    }
}
