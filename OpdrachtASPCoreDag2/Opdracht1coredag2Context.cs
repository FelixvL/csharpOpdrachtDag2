using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OpdrachtASPCoreDag2
{
    public partial class Opdracht1coredag2Context : DbContext
    {
        public Opdracht1coredag2Context()
        {
        }

        public Opdracht1coredag2Context(DbContextOptions<Opdracht1coredag2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Teacher> Teacher { get; set; }
        public virtual DbSet<Motor> Motor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-LS3KMQK;Initial Catalog=Opdracht1CoreDag2;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.Property(e => e.AddedOn)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Salary).HasColumnType("money");

                entity.Property(e => e.Skills)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<Motor>(entity =>
            {

                entity.Property(e => e.Merk)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Prijs);
            });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}