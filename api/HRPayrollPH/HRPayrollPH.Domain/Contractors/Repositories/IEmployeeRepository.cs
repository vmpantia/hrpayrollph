using HRPayrollPH.Domain.Models.Entities;

namespace HRPayrollPH.Domain.Contractors.Repositories
{
    public interface IEmployeeRepository : IBaseRepository<Employee>
    {
        Task<IEnumerable<Employee>> GetEmployeesFullInfoAsync(CancellationToken cancellationToken);
        Task<Employee> GetEmployeeFullInfoAsync(Guid id, CancellationToken cancellationToken);
    }
}