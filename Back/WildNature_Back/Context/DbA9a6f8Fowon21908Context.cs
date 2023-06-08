using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WildNature_Back.Models;

namespace WildNature_Back.Context;

public partial class DbA9a6f8Fowon21908Context : DbContext
{
    protected IConfiguration configuration;
    public DbA9a6f8Fowon21908Context(DbContextOptions options)
        : base(options)
    {
    }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<Family> Families { get; set; }

    public virtual DbSet<Gen> Gens { get; set; }

    public virtual DbSet<Kingdom> Kingdoms { get; set; }

    public virtual DbSet<Species> Species { get; set; }

}
