using HRPayrollPH.Domain.Models.Lites;

namespace HRPayrollPH.Domain.Models.Dtos
{
    public class EmployeeDto
    {
        public Guid Id { get; set; }
        public string UniqueId { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName => string.Concat(LastName, ", ", FirstName, 
                                                string.IsNullOrEmpty(MiddleName) ? string.Empty 
                                                                                 : $"{MiddleName.Substring(0, 1).ToUpper()}.");
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string? BirthPlace { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public LitePosition Position { get; set; }
        public LiteDepartment Department { get; set; }
    }
}
