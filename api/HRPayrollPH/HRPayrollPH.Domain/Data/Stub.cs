using Bogus;
using Bogus.Extensions.UnitedStates;
using HRPayrollPH.Domain.Models.Entities;
using HRPayrollPH.Domain.Models.Enums;

namespace HRPayrollPH.Domain.Data
{
    public class Stub
    {
        public static Faker<Department> GenerateDepartment() =>
            new Faker<Department>()
                .RuleFor(p => p.Id, f => f.Random.Guid())
                .RuleFor(p => p.Name, f => f.Company.CompanyName())
                .RuleFor(p => p.Status, f => f.PickRandom<CommonStatus>())
                .RuleFor(p => p.CreatedAt, f => f.Date.Past())
                .RuleFor(p => p.CreatedBy, f => f.Internet.Email());

        public static Faker<Position> GeneratePosition(IEnumerable<Guid> departmentIds) =>
            new Faker<Position>()
                .RuleFor(p => p.Id, f => f.Random.Guid())
                .RuleFor(p => p.DepartmentId, f => f.PickRandom(departmentIds))
                .RuleFor(p => p.Name, f => f.Company.CompanyName())
                .RuleFor(p => p.Status, f => f.PickRandom<CommonStatus>())
                .RuleFor(p => p.CreatedAt, f => f.Date.Past())
                .RuleFor(p => p.CreatedBy, f => f.Internet.Email());

        public static Faker<Employee> GenerateEmployee(IEnumerable<Guid> positionIds) =>
            new Faker<Employee>()
                .RuleFor(p => p.Id, f => f.Random.Guid())
                .RuleFor(p => p.PositionId, f => f.PickRandom(positionIds))
                .RuleFor(p => p.UniqueId, f => f.Company.Ein())
                .RuleFor(p => p.FirstName, f => f.Name.FirstName())
                .RuleFor(p => p.LastName, f => f.Name.LastName())
                .RuleFor(p => p.Gender, f => f.PickRandom<Gender>())
                .RuleFor(p => p.BirthDate, f => f.Date.Past())
                .RuleFor(p => p.Email, f => f.Internet.Email())
                .RuleFor(p => p.Phone, f => f.Phone.PhoneNumber())
                .RuleFor(p => p.Type, f => f.PickRandom<EmploymentType>())
                .RuleFor(p => p.Status, f => f.PickRandom<CommonStatus>())
                .RuleFor(p => p.CreatedAt, f => f.Date.Past())
                .RuleFor(p => p.CreatedBy, f => f.Internet.Email());
    }
}
