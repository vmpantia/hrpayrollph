using HRPayrollPH.Domain.Models.Entities;

namespace HRPayrollPH.Domain.Contractors.Repositories
{
    public interface IEmployeeRepository : IBaseRepository<Employee>
    {
        Task<IEnumerable<Employee>> GetEmployeesFullInfoAsync();
        Task<Employee> GetEmployeeFullInfoAsync(Guid id);
    }
}