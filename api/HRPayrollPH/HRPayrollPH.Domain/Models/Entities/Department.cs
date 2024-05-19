using HRPayrollPH.Domain.Models.Enums;

namespace HRPayrollPH.Domain.Models.Entities
{
    public class Department : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public CommonStatus Status { get; set; }

        public virtual ICollection<Position> Positions { get; set; }
    }
}
