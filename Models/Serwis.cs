using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp90.Models
{
    public class Serwis
    {
        [Key]
        public string SerwisId { get; set; }
        public DateTime Data { get; set; }
        public int GodzinaRozpoczecia { get; set; }
        public int GodzinaZakonczenia { get; set; }
        public int CzasTrwaniaSerwisu { get; set; }
        public string SzczegółowyOpis { get; set; }
        public bool SprawaZakonczona { get; set; }


        public string FirmaId { get; set; }
        public Firma Firma { get; set; }

        public string SprzetId { get; set; }
        public Sprzet Sprzet { get; set; }


        public List<SerwisZalacznik> SerwisZalaczniki { get; set; }

        public List<ApplicationUserServis> ApplicationUserSerwisy { get; set; } // Serwisanci
    }
}
