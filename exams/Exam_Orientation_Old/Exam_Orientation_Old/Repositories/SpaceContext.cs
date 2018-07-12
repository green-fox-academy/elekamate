using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Exam_Orientation_Old.Models
{
    public partial class SpaceContext : DbContext
    {
        public SpaceContext(DbContextOptions<SpaceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Planet> Planets { get; set; }
        public virtual DbSet<SpaceShip> SpaceShip { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Exam_Orientation_Old;Integrated Security=True;");
        //    }
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Planet>(entity =>
        //    {
        //        entity.Property(e => e.Id).ValueGeneratedNever();

        //        entity.Property(e => e.Name)
        //            .IsRequired()
        //            .HasMaxLength(10)
        //            .IsUnicode(false);
        //    });

        //    modelBuilder.Entity<SpaceShip>(entity =>
        //    {
        //        entity.Property(e => e.Id).ValueGeneratedNever();

        //        entity.Property(e => e.OnPlanet).HasMaxLength(10);
        //    });
        
    }
}
