using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp90.Models
{
    public class ApplicationUserZalacznik
    {
        [Key]
        public string ApplicationUserZalacznikId { get; set; }
        public string Nazwa { get; set; }
        public byte[] Zalacznik { get; set; }


        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

    }
}