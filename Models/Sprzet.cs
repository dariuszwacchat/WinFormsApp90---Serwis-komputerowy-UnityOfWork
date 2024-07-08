using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp90.Models
{
    public class Sprzet
    {
        [Key]
        public string SprzetId { get; set; }
        public string Nazwa { get; set; }
        public bool UrzadzenieSieciowe { get; set; }


        public string RodzajSprzetuId { get; set; }
        public RodzajSprzetu RodzajSprzetu { get; set; }

        public string FirmaId { get; set; }
        public Firma Firma { get; set; }




        public List<SprzetLicencja> SprzetLicencje { get; set; }
        public List<Gwarancja> Gwarancje { get; set; }
        public List<Serwis> Serwisy { get; set; }
        public List<Naprawa> Naprawy { get; set; }
        public List<Archiwizacja> Archiwizacje { get; set; }
        public List<SprzetZdjecie> SprzetZdjecia { get; set; }
        public List<HasloInfo> HaslaInfo { get; set; } 
        public List <Pole> Pola { get; set; } 

    }
}
