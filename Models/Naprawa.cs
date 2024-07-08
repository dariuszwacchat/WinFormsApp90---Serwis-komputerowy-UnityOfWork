using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp90.Models
{
    public class Naprawa
    {
        [Key]
        public string NaprawaId { get; set; } 
        public DateTime DataNaprawy { get; set; }
        public int CzasUdzielonejGwarancji { get; set; } // W miesiącach
        public DateTime DataZakonczeniaGwarancji { get; set; }
        public string Uwagi { get; set; }




        public string FirmaId { get; set; }
        public Firma Firma { get; set; }


        public string SprzetId { get; set; }
        public Sprzet Sprzet { get; set; }

    }
}
