using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp90.Models
{
    public class UmowaZalacznik
    {
        [Key]
        public string UmowaZalacznikId { get; set; }
        public string Nazwa { get; set; }
        public byte[] ZalacznikData { get; set; }


        public string UmowaId { get; set; }
        public Umowa Umowa { get; set; }
    }
}
