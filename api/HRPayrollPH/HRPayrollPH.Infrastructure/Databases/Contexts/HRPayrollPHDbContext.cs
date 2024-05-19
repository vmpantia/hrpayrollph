using HRPayrollPH.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace HRPayrollPH.Infrastructure.Databases.Contexts
{
    public class HRPayrollPHDbContext : DbContext
    {
        public HRPayrollPHDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Department> Departments{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(emp =>
            {
                emp.HasKey(prop => prop.Id);

                emp.HasIndex(prop => new { prop.UniqueId, prop.LastName, prop.Status, prop.Type });

                emp.HasOne(prop => prop.Position)
                   .WithMany(prop => prop.Employees)
                   .HasForeignKey(prop => prop.PositionId);
            });

            modelBuilder.Entity<Position>(pos =>
            {
                pos.HasKey(prop => prop.Id);

                pos.HasIndex(prop => new { prop.Name, prop.Status });

                pos.HasOne(prop => prop.Department)
                   .WithMany(prop => prop.Positions)
                   .HasForeignKey(prop => prop.DepartmentId);

                pos.HasMany(prop => prop.Employees)
                   .WithOne(prop => prop.Position)
                   .HasForeignKey(prop => prop.PositionId);
            });

            modelBuilder.Entity<Department>(dept =>
            {
                dept.HasKey(prop => prop.Id);

                dept.HasIndex(prop => new { prop.Name, prop.Status });

                dept.HasMany(prop => prop.Positions)
                    .WithOne(prop => prop.Department)
                    .HasForeignKey(prop => prop.DepartmentId);
            });     
        }
    }
}
