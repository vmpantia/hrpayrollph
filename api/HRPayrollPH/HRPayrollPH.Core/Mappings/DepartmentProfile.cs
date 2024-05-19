using AutoMapper;
using HRPayrollPH.Domain.Models.Entities;
using HRPayrollPH.Domain.Models.Lites;

namespace HRPayrollPH.Core.Mappings
{
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            CreateMap<Department, LiteDepartment>();
        }
    }
}
