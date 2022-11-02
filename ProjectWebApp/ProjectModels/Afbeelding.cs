using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectModels
{
    public class Afbeelding
    {
        public int Id { get; set; }
        public string linkAfbeelding { get; set; }
        public int AlbumId { get; set; }
        public Album Album { get; set; }
    }
}
