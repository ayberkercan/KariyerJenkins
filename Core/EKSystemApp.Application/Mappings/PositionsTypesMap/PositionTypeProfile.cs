using AutoMapper;
using EKSystemApp.Application.DTO.PositionsTypes;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;

namespace EKSystemApp.Application.Mappings.PositionsTypes
{
    public class PositionTypeProfile : Profile
    {
        public PositionTypeProfile()
        {
            this.CreateMap<PositionType, PositionsTypesDto>().ReverseMap();
        }
    }
}
