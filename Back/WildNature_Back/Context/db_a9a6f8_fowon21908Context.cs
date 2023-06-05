using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WildNature_Back.Models;

namespace WildNature_Back.Context
{
    public partial class db_a9a6f8_fowon21908Context : DbContext
    {
        public db_a9a6f8_fowon21908Context()
        {
        }

        public db_a9a6f8_fowon21908Context(DbContextOptions<db_a9a6f8_fowon21908Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Class> Classes { get; set; } = null!;
        public virtual DbSet<Family> Families { get; set; } = null!;
        public virtual DbSet<Gen> Gens { get; set; } = null!;
        public virtual DbSet<Kingdom> Kingdoms { get; set; } = null!;
        public virtual DbSet<Species> Species { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=SQL5106.site4now.net;Initial Catalog=db_a9a6f8_fowon21908;User Id=db_a9a6f8_fowon21908_admin;Password=fowon21908");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Family>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Gen>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Kingdom>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Species>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Column8)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("column_8");

                entity.Property(e => e.Description)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IdClass).HasColumnName("ID_Class");

                entity.Property(e => e.IdFamily).HasColumnName("ID_Family");

                entity.Property(e => e.IdGen).HasColumnName("ID_Gen");

                entity.Property(e => e.IdKingdom).HasColumnName("ID_Kingdom");

                entity.Property(e => e.Name)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClassNavigation)
                    .WithMany(p => p.Species)
                    .HasForeignKey(d => d.IdClass)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Species_Classes_ID_fk");

                entity.HasOne(d => d.IdFamilyNavigation)
                    .WithMany(p => p.Species)
                    .HasForeignKey(d => d.IdFamily)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Species_Families_ID_fk");

                entity.HasOne(d => d.IdGenNavigation)
                    .WithMany(p => p.Species)
                    .HasForeignKey(d => d.IdGen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Species_Gens_ID_fk");

                entity.HasOne(d => d.IdKingdomNavigation)
                    .WithMany(p => p.Species)
                    .HasForeignKey(d => d.IdKingdom)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Species_Kingdoms_ID_fk");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
