using System;
using System.Collections.Generic;

namespace Dormitory.DAL
{
    public partial class Application
    {
        public int? Id { get; set; }
        public int? StudentId { get; set; }
        public int? Announcement { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public bool? IsActive { get; set; }

        public virtual Student? Id1 { get; set; }
        public virtual Announcement? IdNavigation { get; set; }
    }
}
