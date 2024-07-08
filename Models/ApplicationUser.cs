using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp90.Models
{
    public class ApplicationUser : IdentityUser <string>
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public string AdresZamieszkania { get; set; }
        public string PrywatnyTelefon { get; set; }
        public string TelefonSluzbowy { get; set; }
        public string AdresEmailSluzbowy { get; set; }
        public string NumerGG { get; set; }
        public string Uwagi { get; set; }


        public List <Wiedza> Wiedza { get; set; }
        public List<ApplicationUserZalacznik> ApplicationUserZalaczniki { get; set; }
        public List<ApplicationUserServis> ApplicationUserSerwisy { get; set; } // Serwisanci
    }
}
