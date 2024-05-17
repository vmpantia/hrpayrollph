using HRPayrollPH.Domain.Contractors.Repositories;
using HRPayrollPH.Domain.Models.Entities;
using HRPayrollPH.Domain.Models.Enums;
using HRPayrollPH.Infrastructure.Databases.Contexts;
using Microsoft.EntityFrameworkCore;

namespace HRPayrollPH.Infrastructure.Databases.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(HRPayrollPHDbContext context) : base(context) { }

        public async Task<IEnumerable<Employee>> GetEmployeesAsync() =>
            await All.Where(data => data.Status != EmployeeStatus.Deleted).ToListAsync();

        public async Task<Employee> GetEmployeeAsync(Guid id) =>
            await Find(data => data.Id == id).FirstAsync();
    }
}
