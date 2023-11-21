using AutoMapper;
using EKSystemApp.Application.DTO.Advert.Create;
using EKSystemApp.Application.DTO.Advert.List;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;

namespace EKSystemApp.Application.Mappings.AdvertMap
{
    public class AdvertProfile:Profile
    {
        public AdvertProfile()
        {
            CreateMap<AdvertCreate, CreateAdvertDto>().ReverseMap();
            CreateMap<AdvertCreate, AdvertListDto>().ReverseMap();
        }
    }
}
