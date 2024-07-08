using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp90.Models
{
    public class SprzetItem
    {
        [Key]
        public string SprzetItemId { get; set; }
        public string Nazwa { get; set; }


        public List<PoleItem> PolaItems { get; set; }
        public List<SprzetItemZalacznik> SprzetItemZalaczniki { get; set; }
    }
}
