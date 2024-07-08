using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp90.Models
{
    public class Oferta
    {
        [Key]
        public string OfertaId { get; set; }
        public string Tresc { get; set; }
        public double Cena { get; set; }

    }
}
