using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp90.Models
{
    public class HasloInfo
    {
        [Key]
        public string HasloInfoId { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }
        public string Uwagi { get; set; }


        public string FirmaId { get; set; }
        public Firma Firma { get; set; }

        public string SprzetId { get; set; }
        public Sprzet Sprzet { get; set; }
    }
}
