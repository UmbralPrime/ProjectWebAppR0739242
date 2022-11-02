using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectModels
{
    public class ArtikelGroep
    {
        public int Id { get; set; }
        public int GroepId { get; set; }
        public int ArtikelId { get; set; }
        public Groep Groep { get; set; }
        public Artikel Artikel { get; set; }
    }
}
