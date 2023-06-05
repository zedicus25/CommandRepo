﻿using System;
using System.Collections.Generic;

namespace WildNature_Back.Models
{
    public partial class Kingdom
    {
        public Kingdom()
        {
            Species = new HashSet<Species>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Species> Species { get; set; }
    }
}
