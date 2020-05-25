using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HouseDB
{
    public partial class HousesContext : DbContext
    {
        public HousesContext()
        {
        }

        public HousesContext(DbContextOptions<HousesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<House> House { get; set; }
        public virtual DbSet<HouseDetails> HouseDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Houses;integrated security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<House>(entity =>
            {
                entity.Property(e => e.AgentEmail).HasMaxLength(50);

                entity.Property(e => e.AgentName).HasMaxLength(50);

                entity.Property(e => e.AgentPhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BuiltDate).HasColumnType("datetime");

                entity.Property(e => e.HouseAddress)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LotSize).HasMaxLength(20);

                entity.Property(e => e.Notes).HasMaxLength(1000);
            });

            modelBuilder.Entity<HouseDetails>(entity =>
            {
                entity.HasKey(e => e.HouseId);

                entity.Property(e => e.AgentEmail).HasMaxLength(50);

                entity.Property(e => e.AgentName).HasMaxLength(50);

                entity.Property(e => e.AgentPhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BuiltDate).HasColumnType("datetime");

                entity.Property(e => e.HouseAddress)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LotSize).HasMaxLength(20);

                entity.Property(e => e.Notes).HasMaxLength(1000);

                entity.Property(e => e.ZipCode).HasMaxLength(10);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
