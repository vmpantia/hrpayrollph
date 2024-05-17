using HRPayrollPH.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace HRPayrollPH.Infrastructure.Databases.Contexts
{
    public class HRPayrollPHDbContext : DbContext
    {
        public HRPayrollPHDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(emp =>
            {
                emp.HasIndex(prop => new { prop.UniqueId, prop.Status, prop.Type });
            });
        }
    }
}
