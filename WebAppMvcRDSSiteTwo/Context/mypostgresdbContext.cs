using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebAppMvcRDSSiteTwo.Models;

#nullable disable

namespace WebAppMvcRDSSiteTwo.Context
{
    public partial class mypostgresdbContext : DbContext
    {
        public mypostgresdbContext()
        {
        }

        public mypostgresdbContext(DbContextOptions<mypostgresdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Sale> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseNpgsql("Host=database-2.cqaxyfagdlth.us-east-2.rds.amazonaws.com;Database=mypostgresdb;Username=postgres;Password=Jedi2020;port=5432;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "en_US.UTF-8");

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.ToTable("sales");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasPrecision(18, 2)
                    .HasColumnName("amount");

                entity.Property(e => e.Productname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("productname");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
