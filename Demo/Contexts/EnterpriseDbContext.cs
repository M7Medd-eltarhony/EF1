using EntityframeworkFluentAPIs;
using Demo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Configurations;

namespace Demo.Contexts
{
    internal class EnterpriseDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server = . ; Database = Enterprise; Trusted_Connection = true ");
        //optionsBuilder.UseSqlServer("Data source = . ; Initial Catalog = Enterprise; Integrated Security = true "); //Old

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ///modelBuilder.Entity<Department>()
            ///            .HasKey(D => D.DeptId);             
            ///modelBuilder.Entity<Department>()
            ///            .Property(D => D.DeptId)
            ///            .UseIdentityColumn(10, 10);             
            ///modelBuilder.Entity<Department>()
            ///            .Property(D => D.Name)
            ///            .HasColumnName("DepartmentName")
            ///            .HasColumnType("varchar")
            ///            .HasMaxLength(50)
            ///            .HasDefaultValue("Test")
            ///            .IsRequired(false);
            ///.HasAnnotation("", "");             
            ///modelBuilder.Entity<Department>()
            ///            .Property(D => D.DateOfCreation)
            ///            //.HasDefaultValue(DateTime.Now);
            ///            .HasDefaultValueSql("GETDATE()");

            ///modelBuilder.Entity<Department>(E =>
            ///{
            ///    E.HasKey(D => D.DeptId);             
            ///    E.Property(D => D.DeptId)
            ///     .UseIdentityColumn(10, 10);             
            ///    E.Property(D => D.Name)
            ///     .HasColumnName("DepartmentName")
            ///     .HasColumnType("varchar")
            ///     .HasMaxLength(50)
            ///     .HasDefaultValue("Test")
            ///     .IsRequired(false);
            ///    //.HasAnnotation("", "");             
            ///    E.Property(D => D.DateOfCreation)
            ///     //.HasDefaultValue(DateTime.Now);
            ///     .HasDefaultValueSql("GETDATE()");
            ///});

            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());


            base.OnModelCreating(modelBuilder);
        }

    }
}
