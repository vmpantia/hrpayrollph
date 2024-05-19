using HRPayrollPH.Domain.Models.Dtos;
using HRPayrollPH.Domain.Results;
using MediatR;

namespace HRPayrollPH.Core.Queries.Models
{
    public class GetEmployeesQuery : IRequest<ApiResponse<IEnumerable<EmployeeDto>>> { }
}
