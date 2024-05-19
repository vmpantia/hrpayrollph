using AutoMapper;
using HRPayrollPH.Domain.Models.Entities;
using HRPayrollPH.Domain.Models.Lites;

namespace HRPayrollPH.Core.Mappings
{
    public class PositionProfile : Profile
    {
        public PositionProfile()
        {
            CreateMap<Position, LitePosition>();
        }
    }
}
