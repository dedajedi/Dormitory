using System;
using System.Collections.Generic;

namespace Dormitory.DAL
{
    public partial class Dormitory
    {
        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int MaxCapacity { get; set; }

        public virtual Room? Room { get; set; }
    }
}
