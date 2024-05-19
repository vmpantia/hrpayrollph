using HRPayrollPH.Domain.Models.Enums;

namespace HRPayrollPH.Domain.Models.Entities
{
    public class Position : BaseEntity<Guid>
    {
        public Guid DepartmentId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public CommonStatus Status { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
