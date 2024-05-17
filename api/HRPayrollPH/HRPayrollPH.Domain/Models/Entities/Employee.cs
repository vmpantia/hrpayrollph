using HRPayrollPH.Domain.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace HRPayrollPH.Domain.Models.Entities
{
    [PrimaryKey(nameof(Id))]
    public class Employee : BaseEntity<Guid>
    {
        public string UniqueId { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateOnly BirthDate { get; set; }
        public string? BirthPlace { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public EmploymentType Type { get; set; }
        public EmployeeStatus Status { get; set; }
    }
}
