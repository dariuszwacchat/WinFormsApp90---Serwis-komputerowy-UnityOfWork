using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp90.Models
{
    public class Archiwizacja
    {
        [Key]
        public string ArchiwizacjaId { get; set; }
        public string DaneDoArchiwizacji { get; set; }
        public int CzestotliwoscArchiwizacji { get; set; }
        public DateTime DataArchiwizacji { get; set; }
        public string NosnikArchiwizacji { get; set; }
        public string KopiaPrzekazana { get; set; }
        public string Uwagi { get; set; }


        public string FirmaId { get; set; }
        public Firma Firma { get; set; }

        public string SprzetId { get; set; }
        public Sprzet Sprzet { get; set; }
    }
}
