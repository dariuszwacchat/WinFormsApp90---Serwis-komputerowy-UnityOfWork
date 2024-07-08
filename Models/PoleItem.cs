using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp90.Models.Enums;

namespace WinFormsApp90.Models
{
    public class PoleItem
    {
        [Key]
        public string PoleItemId { get; set; }
        public string Name { get; set; }
        public RodzajPola RodzajPola { get; set; }


        public string SprzetItemId { get; set; }
        public SprzetItem SprzetItem { get; set; }
    }
}
