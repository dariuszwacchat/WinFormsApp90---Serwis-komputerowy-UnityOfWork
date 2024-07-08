using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp90.Models
{
    public class Umowa
    {
        [Key]
        public string UmowaId { get; set; }
        public string NumerUmowy { get; set; }
        public bool CzasNieokreslony { get; set; }
        public double KwotaMiesieczna { get; set; }
        public string DataRozpoczecia { get; set; }
        public string DataZakonczenia { get; set; }
        public int OkresWypowiedzenia { get; set; }
        public string Uwagi { get; set; }


        public string FirmaId { get; set; }
        public Firma Firma { get; set; }

        public List <UmowaZalacznik> UmowaZalaczniki { get; set; }
    }
}
