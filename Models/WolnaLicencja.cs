using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp90.Models.Enums;

namespace WinFormsApp90.Models
{
    public class WolnaLicencja
    {
        [Key]
        public string WolnaLicencjaId { get; set; } 
        public string KluczLicencji { get; set; }
        public int IloscLicencji { get; set; }
        public DateTime DataZakupu { get; set; }
        public DateTime DataWaznosci { get; set; }
        public string MiejsceZakupu { get; set; } 
        public string Uwagi { get; set; }  



        public List <WolnaLicencjaZalacznik> WolnaLicencjaZalaczniki { get; set; }
    }
}
