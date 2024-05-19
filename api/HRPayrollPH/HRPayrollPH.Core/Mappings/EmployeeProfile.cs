using AutoMapper;
using HRPayrollPH.Domain.Models.Dtos;
using HRPayrollPH.Domain.Models.Entities;

namespace HRPayrollPH.Core.Mappings
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeDto>()
                .ForMember(dst => dst.Gender, opt => opt.MapFrom(src => src.Gender.ToString()))
                .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status.ToString()))
                .ForMember(dst => dst.Type, opt => opt.MapFrom(src => src.Type.ToString()))
                .ForMember(dst => dst.Position, opt => opt.MapFrom(src => src.Position))
                .ForMember(dst => dst.Department, opt => opt.MapFrom(src => src.Position.Department));
        }
    }
}
