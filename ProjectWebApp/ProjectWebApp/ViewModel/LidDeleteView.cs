using ProjectModels;

namespace ProjectWebApp.ViewModel
{
    public class LidDeleteView
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public string Email { get; set; }
        public bool IsOuder { get; set; }
        public bool Betaald { get; set; }
        public string Telefoon { get; set; }
        public DateTime Geboortedatum { get; set; }
        public Groep Groep { get; set; }
    }
}
