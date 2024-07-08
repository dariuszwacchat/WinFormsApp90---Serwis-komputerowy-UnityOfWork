using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp90.Models
{
    public class Gwarancja
    {
        [Key]
        public string GwarancjaId { get; set; }  
         
        public DateTime DataRozpoczeciaGwarancji { get; set; }
        public int CzasGwarancji { get; set; } // W miesiącach
        public DateTime DataZakonczeniaGwarancji { get; set; }
        public string Uwagi { get; set; }


        public string FirmaId { get; set; }
        public Firma Firma { get; set; }

        public string SprzetId { get; set; }
        public Sprzet Sprzet { get; set; }

        public List <GwarancjaZdjecie> GwarancjaZdjecia { get; set; }

    }
}
