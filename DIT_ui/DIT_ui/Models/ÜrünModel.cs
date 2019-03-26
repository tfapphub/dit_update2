using System;
using System.Collections.Generic;
using System.Text;

namespace DIT_ui.Models
{
   public class ÜrünModel
    {
        public string ürünBarkod { get; set; }
        public string ürünAdi { get; set; }
        public string aciklama { get; set; }
        public int miktar { get; set; }
        public string fotoUrl { get; set; }
        public double fiyat { get; set; }
    }
}
