using HRPayrollPH.Domain.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace HRPayrollPH.Domain.Models.Entities
{
    [PrimaryKey(nameof(Id))]
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
