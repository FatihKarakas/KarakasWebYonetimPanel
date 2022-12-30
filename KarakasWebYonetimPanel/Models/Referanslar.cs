using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KarakasWebYonetimPanel.Models
{
    public partial class Referanslar
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string ResimAdres { get; set; }
        public byte ProjeAktifmi { get; set; }
        public string CalismaSuresi { get; set; }
        public string Platform { get; set; }
        public string Kurum { get; set; }
        public string LinUrl { get; set; }
        public byte Yayinda { get; set; }
    }
}
