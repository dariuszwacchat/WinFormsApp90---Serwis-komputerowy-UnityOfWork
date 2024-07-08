using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp90.Models
{
    public class InformacjaSprzedazowaZalacznik
    {
        [Key]
        public string InformacjaSprzedazowaZalacznikId { get; set; }
        public string Nazwa { get; set; }
        public byte[] Data { get; set; }


        public string InformacjeSprzedazoweId { get; set; }
        public InformacjeSprzedazowe InformacjeSprzedazowe { get; set; }
    }
}
