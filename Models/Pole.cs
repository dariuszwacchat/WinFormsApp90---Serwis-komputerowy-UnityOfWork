using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp90.Models
{
    public class Pole
    {
        [Key]
        public string PoleId { get; set; }
        public string Name { get; set; } 
        public string Wartosc { get; set; }


        public string SprzetId { get; set; }
        public Sprzet Sprzet { get; set; }
    }
}
