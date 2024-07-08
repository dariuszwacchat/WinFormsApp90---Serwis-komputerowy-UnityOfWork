using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp90.Models
{
    public class SprzetItemZalacznik
    {
        [Key]
        public string SprzetItemZalacznikId { get; set; }
        public string Nazwa { get; set; }
        public byte [] Data { get; set; }


        public string SprzetItemId { get; set; }
        public SprzetItem SprzetItem { get; set; }
    }
}
