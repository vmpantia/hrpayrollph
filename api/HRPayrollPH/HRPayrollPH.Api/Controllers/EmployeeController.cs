using HRPayrollPH.Core.Queries.Models;
using HRPayrollPH.Domain.Models.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HRPayrollPH.Api.Controllers
{
    [ApiController]
    [Route("employees")]
    public class EmployeeController : BaseController
    {
        public EmployeeController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        public async Task<IActionResult> GetEmployees() =>
            await HandleRequestAsync<GetEmployeesQuery, IEnumerable<EmployeeDto>>(new GetEmployeesQuery());
    }
}
