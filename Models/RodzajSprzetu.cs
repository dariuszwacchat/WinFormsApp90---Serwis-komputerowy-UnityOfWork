using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp90.Models
{
    public class RodzajSprzetu
    {
        // np. Komputer, Monitor, Drukarka, Router
        [Key]
        public string RodzajSprzetuId { get; set; }
        public string Nazwa { get; set; }


        public string FirmaId { get; set; }
        public Firma Firma { get; set; }

        public List<Sprzet> Sprzet { get; set; }
        public List<InformacjeSprzedazowe> InformacjeSprzedazowe { get; set; }
    }
}
