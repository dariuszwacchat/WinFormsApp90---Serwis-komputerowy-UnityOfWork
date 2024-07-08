using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp90.Models
{
    public class SprzetLicencja
    {
        public string SprzetLicencjaId { get; set; }
        public string NazwaProgramu { get; set; }
        public string KluczLicencji { get; set; }
        public DateTime DataZakonczenia { get; set; }
        public string Uwagi { get; set; }


        public string FirmaId { get; set; }
        public Firma Firma { get; set; }


        public string SprzetId { get; set; }
        public Sprzet Sprzet { get; set; }


        public List <SprzetLicencjaZalacznik> SprzetLicencjaZalaczniki { get; set; }
    }
}
