using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ProjectWebApp.Areas.Identity.Data
{
    public class CustomUser : IdentityUser
    {
        [PersonalData, MaxLength(50,ErrorMessage ="De ingevulde naam is te lang. De maximale lengte is 50"),Required]
        
        public string Naam { get; set; }
        [PersonalData, Required]
        public string Voornaam { get; set; }
        //[PersonalData, AllowNull]
        //public string Straat { get; set; }
        //[PersonalData, AllowNull]
        //public int Huisnummer { get; set; }
        //[PersonalData, AllowNull]
        //public string Postcode { get; set; }
        //[PersonalData, AllowNull]
        //public string Gemeente { get; set; }
        //[PersonalData, DataType(DataType.Date), AllowNull]
        //public DateTime Geboortedatum { get; set; }


    }
}
