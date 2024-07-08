using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp90.Models
{
    public class WolnaLicencjaZalacznik
    {
        [Key]
        public string WolnaLicencjaZalacznikId { get; set; }
        public string Nazwa { get; set; }
        public byte[] Data { get; set; }



        public string WolnaLicencjaId { get; set; }
        public WolnaLicencja WolnaLicencja { get; set; }
    }
}
