using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp90.Models
{
    public class Hosting
    {
        [Key]
        public string HostingId { get; set; }
        public string Information { get; set; }


        public string FirmaId { get; set; }
        public Firma Firma { get; set; } 
    }
}
