using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FinalProject
{
    public partial class db_houseDetailsContext : DbContext
    {
        public db_houseDetailsContext()
        {
        }

        public db_houseDetailsContext(DbContextOptions<db_houseDetailsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<HouseDetails> House { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=localhost\\SQLExpress;Initial Catalog=db_houseDetails;integrated security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HouseDetails>(entity =>
            {
                entity.Property(e => e.BuiltDate).HasColumnType("date");

               
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
