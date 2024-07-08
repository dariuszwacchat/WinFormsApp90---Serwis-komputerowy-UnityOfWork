using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp90.Models
{
    public class Kontakt
    {
        [Key]
        public string KontaktId { get; set; }
        public string Adres { get; set; }
        public string OsobaKontaktowa { get; set; }
        public string NumerTelefonu { get; set; }
        public string AdresEmail { get; set; }


        public string FirmaId { get; set; }
        public Firma Firma { get; set; }
    }
}
