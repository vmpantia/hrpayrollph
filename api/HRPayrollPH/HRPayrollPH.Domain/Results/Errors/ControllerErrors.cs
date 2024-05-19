using HRPayrollPH.Domain.Models.Enums;

namespace HRPayrollPH.Domain.Results.Errors
{
    public class ControllerErrors
    {
        public static Error Unexpected(Exception exception) => new(ErrorType.Unexpected, nameof(exception), exception.ToString());
    }
}
