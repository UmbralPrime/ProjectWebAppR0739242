using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectModels
{
    public class LidGroep
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int LidId { get; set; }
        [Required]
        public int GroepId { get; set; }
        public Lid Lid { get; set; }
        public Groep Groep { get; set; }
    }
}
