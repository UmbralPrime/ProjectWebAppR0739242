using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectModels
{
    public class Album
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public DateTime Datum { get; set; }
        public List<Afbeelding> Afbeeldingen { get; set; }
    }
}
