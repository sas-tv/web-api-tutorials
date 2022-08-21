using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using EmployeeManagementSystem.Repositories.Entities;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EmployeeManagementSystem.Repositories.DatabaseContexts
{
    public partial class EmsContext : DbContext
    {
        public EmsContext()
        {
        }

        public EmsContext(DbContextOptions<EmsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Competencies> Competencies { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=ems;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Competencies>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_Competencies")
                    .IsUnique();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Departments>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_Departments")
                    .IsUnique();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasIndex(e => e.Email)
                    .HasName("IX_Employees")
                    .IsUnique();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.DateOfJoining).HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Competency)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.CompetencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employees_Competencies");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employees_Departments");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
