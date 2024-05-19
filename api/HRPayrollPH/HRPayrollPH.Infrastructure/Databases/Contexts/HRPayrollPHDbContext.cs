using HRPayrollPH.Domain.Data;
using HRPayrollPH.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace HRPayrollPH.Infrastructure.Databases.Contexts
{
    public class HRPayrollPHDbContext : DbContext
    {
        private readonly List<Employee> _stubEmployees;
        private readonly List<Position> _stubPositions;
        private readonly List<Department> _stubDepartments;
        public HRPayrollPHDbContext(DbContextOptions options) : base(options)
        {
            _stubDepartments = Stub.GenerateDepartment()
                                   .Generate(100);

            _stubPositions = Stub.GeneratePosition(_stubDepartments.Select(data => data.Id))
                                 .Generate(100);

            _stubEmployees = Stub.GenerateEmployee(_stubPositions.Select(data => data.Id))
                                 .Generate(2000);
        }

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

                emp.HasData(_stubEmployees);
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

                pos.HasData(_stubPositions);
            });

            modelBuilder.Entity<Department>(dept =>
            {
                dept.HasKey(prop => prop.Id);

                dept.HasIndex(prop => new { prop.Name, prop.Status });

                dept.HasMany(prop => prop.Positions)
                    .WithOne(prop => prop.Department)
                    .HasForeignKey(prop => prop.DepartmentId);

                dept.HasData(_stubDepartments);
            });     
        }
    }
}
