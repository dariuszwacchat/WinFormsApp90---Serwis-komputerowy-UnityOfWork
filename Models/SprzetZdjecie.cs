using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp90.Models
{
    public class SprzetZdjecie
    {
        [Key]
        public string SprzetZdjecieId { get; set; }
        public string Nazwa { get; set; }
        public byte[] Data { get; set; }


        public string SprzetId { get; set; }
        public Sprzet Sprzet { get; set; }
    }
}
