using AutoMapper;
using EKSystemApp.Application.DTO.PositionsTypes.List;
using EKSystemApp.Domain.Entities.Admin.Eba;

namespace EKSystemApp.Application.Mappings.PositionsTypes
{
    public class PositionTypeProfile : Profile
    {
        public PositionTypeProfile()
        {
            this.CreateMap<Position, PositionsTypesDto>().ReverseMap();
        }
    }
}
