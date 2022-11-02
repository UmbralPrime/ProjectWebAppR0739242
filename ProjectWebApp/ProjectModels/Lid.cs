using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectModels
{
    public class Lid
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public string Email { get; set; }
        public bool IsOuder { get; set; }
        public bool Betaald { get; set; }
        public string Telefoon { get; set; }
        public DateTime Geboortedatum { get; set; }
    }
}
