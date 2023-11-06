using AutoMapper;
using EKSystemApp.Application.DTO.Eba.EbaPosition;
using EKSystemApp.Domain.Entities.Admin.Eba;

namespace EKSystemApp.Application.Mappings.Eba.EbaPositionMap
{
    public class EbaPositionProfile:Profile
    {
        public EbaPositionProfile()
        {
            this.CreateMap<Position, EbaPositionDto>().ReverseMap();
        }
    }
}
