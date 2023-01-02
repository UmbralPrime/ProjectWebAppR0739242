using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectModels
{
    public class Afbeelding
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string linkAfbeelding { get; set; }
        [Required]
        public int AlbumId { get; set; }
        public Album Album { get; set; }
    }
}
