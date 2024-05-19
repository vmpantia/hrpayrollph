using AutoMapper;
using HRPayrollPH.Core.Queries.Models;
using HRPayrollPH.Domain.Contractors.Repositories;
using HRPayrollPH.Domain.Models.Dtos;
using HRPayrollPH.Domain.Results;
using HRPayrollPH.Domain.Results.Errors;
using MediatR;

namespace HRPayrollPH.Core.Queries.Handlers
{
    public class EmployeeHandler : IRequestHandler<GetEmployeesQuery, ApiResponse<IEnumerable<EmployeeDto>>>
    {
        private readonly IEmployeeRepository _employee;
        private readonly IMapper _mapper;
        public EmployeeHandler(IEmployeeRepository employee, IMapper mapper)
        {
            _employee = employee;
            _mapper = mapper;
        }

        public async Task<ApiResponse<IEnumerable<EmployeeDto>>> Handle(GetEmployeesQuery request, CancellationToken cancellationToken)
        {
            // Get employees full information in database
            var result = await _employee.GetEmployeesFullInfoAsync(cancellationToken);

            // Check if the result is NULL
            if (result is null) return ApiResponse<IEnumerable<EmployeeDto>>.Failure(EmployeeErrors.NULL);

            // Convert result or entities to dto
            var dto = _mapper.Map<IEnumerable<EmployeeDto>>(result);

            return ApiResponse<IEnumerable<EmployeeDto>>.Success(dto);
        }
    }
}
