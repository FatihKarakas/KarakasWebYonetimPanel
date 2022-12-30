using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KarakasWebYonetimPanel.Models
{
    public partial class Comment
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string Content { get; set; }
        public bool IsAccept { get; set; }
        public DateTime CreateDate { get; set; }
        public int PostId { get; set; }
        public int ParentId { get; set; }
        public string IpAdres { get; set; }

        public virtual Post Post { get; set; }
    }
}
