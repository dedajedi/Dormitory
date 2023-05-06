using System;
using System.Collections.Generic;

namespace Dormitory.DAL
{
    public partial class Announcement
    {
        public int Id { get; set; }
        public string? Tittle { get; set; }
        public string? Description { get; set; }
        public DateTime? PublishedDate { get; set; }
        public bool? IsActive { get; set; }
    }
}
