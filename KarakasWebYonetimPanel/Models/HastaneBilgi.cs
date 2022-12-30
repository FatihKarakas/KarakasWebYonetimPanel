using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KarakasWebYonetimPanel.Models
{
    public partial class HastaneBilgi
    {
        public int Id { get; set; }
        public string HastaneAdi { get; set; }
        public string Vkn { get; set; }
        public byte IsActive { get; set; }
    }
}
