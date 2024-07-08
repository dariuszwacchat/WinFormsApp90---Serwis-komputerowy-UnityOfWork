using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp90.Models
{
    public class GwarancjaZdjecie
    {
        [Key]
        public string GwarancjaZdjecieId { get; set; }
        public string Nazwa { get; set; }
        public byte[] Data { get; set; }


        public string GwarancjaId { get; set; }
        public Gwarancja Gwarancja { get; set; }
    }
}
