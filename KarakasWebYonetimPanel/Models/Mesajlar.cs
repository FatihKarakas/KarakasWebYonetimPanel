using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KarakasWebYonetimPanel.Models
{
    public partial class Mesajlar
    {
        public int Id { get; set; }
        public string TamAd { get; set; }
        public string Eposta { get; set; }
        public string Mesaj { get; set; }
        public DateTime Zaman { get; set; }
        public string Ipadres { get; set; }
    }
}
