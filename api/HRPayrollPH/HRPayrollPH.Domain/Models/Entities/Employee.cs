﻿using HRPayrollPH.Domain.Models.Enums;

namespace HRPayrollPH.Domain.Models.Entities
{
    public class Employee : BaseEntity<Guid>
    {
        public Guid PositionId { get; set; }
        public string UniqueId { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string? BirthPlace { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public EmploymentType Type { get; set; }
        public CommonStatus Status { get; set; }

        public virtual Position Position { get; set; }
    }
}
