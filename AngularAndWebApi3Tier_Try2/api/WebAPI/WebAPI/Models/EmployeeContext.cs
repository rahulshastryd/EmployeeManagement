using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebAPI.Models
{
    public partial class EmployeeContext : DbContext
    {
        public EmployeeContext()
        {
        }

        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeAudit> EmployeeAudits { get; set; }
        public virtual DbSet<Employeemaster> Employeemasters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESK00099\\SQLEXPRESS17;initial catalog=EmployeeDB;Integrated Security=True;ConnectRetryCount=0");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.DepartmentName).IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.EmployeeName).IsUnicode(false);

                entity.Property(e => e.PhotoFileName).IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeAudit>(entity =>
            {
                entity.Property(e => e.AuditType).IsUnicode(false);

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.EmployeeName).IsUnicode(false);

                entity.Property(e => e.Photofilename).IsUnicode(false);
            });

            modelBuilder.Entity<Employeemaster>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Employee__1788CC4C184F35A0");

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.ContactNo).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.LoginName).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.UserName).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
