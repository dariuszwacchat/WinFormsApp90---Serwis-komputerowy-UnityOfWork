using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp90.Models
{
    public class Firma
    {
        [Key]
        public string FirmaId { get; set; }
        public string PelnaNazwa { get; set; }
        public string SkroconaNazwa { get; set; }
        public string Adres { get; set; }
        public string Nip { get; set; }
        public string Uwagi { get; set; }


        public List <Kontakt> Kontakty { get; set; } 

        public List<RodzajSprzetu> RodzajeSprzetow { get; set; }

        public List<Sprzet> Sprzet { get; set; }
        public List<Umowa> Umowy { get; set; }
        public List<Hosting> Hosting { get; set; }
        //public List<Termin> Terminy { get; set; }
        public List<InformacjeSprzedazowe> InformacjeSprzedazowe { get; set; }
        public List<Serwis> Serwisy { get; set; }
        public List<SprzetLicencja> SprzetLicencje { get; set; }
        public List<Gwarancja> Gwarancje { get; set; }
        public List<Naprawa> Naprawy { get; set; }
        public List<Archiwizacja> Archiwizacje { get; set; }
        public List<HasloInfo> HaslaInfos { get; set; } 

    }
}
