using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp90.Models
{
    public class Wiedza
    {
        [Key]
        public string WiedzaId { get; set; }
        public string Temat { get; set; }
        public string Rozwiazanie { get; set; }
        public DateTime DataDodania { get; set; }

        public string KtoDodalId { get; set; }
        public ApplicationUser KtoDodal { get; set; }


        public List <WiedzaZdjecie> WiedzaZdjecia { get; set; }
    }
}
