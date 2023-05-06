using System;
using System.Collections.Generic;

namespace Dormitory.DAL
{
    public partial class Room
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? DormitoryId { get; set; }
        public int? Capacity { get; set; }

        public virtual Dormitory IdNavigation { get; set; } = null!;
    }
}
