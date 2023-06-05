using System;
using System.Collections.Generic;

namespace WildNature_Back.Models
{
    public partial class Species
    {
        public int Id { get; set; }
        public int IdKingdom { get; set; }
        public int IdClass { get; set; }
        public int IdFamily { get; set; }
        public int IdGen { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Column8 { get; set; } = null!;

        public virtual Class IdClassNavigation { get; set; } = null!;
        public virtual Family IdFamilyNavigation { get; set; } = null!;
        public virtual Gen IdGenNavigation { get; set; } = null!;
        public virtual Kingdom IdKingdomNavigation { get; set; } = null!;
    }
}
