using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp90.Models
{
    public class SerwisZalacznik
    {
        [Key]
        public string SerwisZalacznikId { get; set; }
        public string Nazwa { get; set; }
        public byte[] Data { get; set; }


        public string SerwisId { get; set; }
        public Serwis Serwis { get; set; }
    }
}
