﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp90.Models
{
    public class SprzetLicencjaZalacznik
    {
        [Key]
        public string SprzetLicencjaZalacznikId { get; set; }
        public string Nazwa { get; set; }
        public byte[] Data { get; set; }



        public string SprzetLicencjaId { get; set; }
        public SprzetLicencja SprzetLicencja { get; set; }
    }
}
