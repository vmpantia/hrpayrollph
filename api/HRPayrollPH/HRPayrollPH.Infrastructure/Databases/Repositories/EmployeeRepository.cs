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

        public async Task<IEnumerable<Employee>> GetEmployeesFullInfoAsync(CancellationToken cancellationToken) =>
            await All.Include(tbl => tbl.Position)
                        .ThenInclude(tbl => tbl.Department)
                     .Where(data => data.Status != CommonStatus.Deleted)
                     .AsSplitQuery()
                     .ToListAsync(cancellationToken);

        public async Task<Employee> GetEmployeeFullInfoAsync(Guid id, CancellationToken cancellationToken) =>
            await Find(data => data.Id == id)
                     .Include(tbl => tbl.Position)
                        .ThenInclude(tbl => tbl.Department)
                     .Where(data => data.Status != CommonStatus.Deleted)
                     .AsSplitQuery()
                     .FirstAsync(cancellationToken);
    }
}
