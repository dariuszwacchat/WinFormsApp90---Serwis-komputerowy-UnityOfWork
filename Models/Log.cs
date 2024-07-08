using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp90.Models
{
    public class Log
    {
        [Key]
        public string LogId { get; set; }
        public string Formularz { get; set; }
        public string Metoda { get; set; }
        public string Komunikat { get; set; }
        public DateTime DataDodania { get; set; }

        /*public string Klikniecie { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }*/
    }
}
