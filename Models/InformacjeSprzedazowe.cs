using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp90.Models
{
    public class InformacjeSprzedazowe
    {
        [Key]
        public string InformacjeSprzedazoweId { get; set; }
        public string NazwaProduktu { get; set; }
        public double Cena { get; set; }
        public string Uwagi { get; set; }
         


        public string FirmaId { get; set; }
        public Firma Firma { get; set; }


        public string RodzajSprzetuId { get; set; }
        public RodzajSprzetu RodzajSprzetu { get; set; }


        public List <InformacjaSprzedazowaZalacznik> InformacjaSprzedazowaZalaczniki { get; set; }
    }
}
