using HRPayrollPH.Domain.Models.Entities;

namespace HRPayrollPH.Domain.Contractors.Repositories
{
    public interface IEmployeeRepository : IBaseRepository<Employee>
    {
        Task<Employee> GetEmployeeAsync(Guid id);
        Task<IEnumerable<Employee>> GetEmployeesAsync();
    }
}