using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp90.Models
{
    public class ApplicationUserServis
    {
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public string SerwisId { get; set; }
        public Serwis Serwis { get; set; }
    }
}
