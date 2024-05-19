using HRPayrollPH.Domain.Models.Enums;

namespace HRPayrollPH.Domain.Results.Errors
{
    public class EmployeeErrors
    {
        public static Error NULL => new(ErrorType.NULL, "Employee", "Employees result cannot be NULL.");
    }
}
