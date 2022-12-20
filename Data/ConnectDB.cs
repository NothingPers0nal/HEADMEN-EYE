using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HEADMEN_EYE.Data
{
    public partial class ConnectDB : DbContext
    {
        public ConnectDB()
        {
            Database.EnsureCreated();
        }

        public ConnectDB(DbContextOptions<ConnectDB> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentGroup> StudentGroups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("DataSource=HEADMEN_EYE_DB0.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.StudentGroupNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.StudentGroup);
            });

            modelBuilder.Entity<StudentGroup>(entity =>
            {
                entity.HasKey(e => e.StudentGroup1);

                entity.Property(e => e.StudentGroup1).HasColumnName("StudentGroup");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
