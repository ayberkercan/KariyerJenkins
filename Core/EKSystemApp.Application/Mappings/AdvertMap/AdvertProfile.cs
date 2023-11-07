using AutoMapper;
using EKSystemApp.Application.DTO.Advert.Create;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;

namespace EKSystemApp.Application.Mappings.AdvertMap
{
    public class AdvertProfile:Profile
    {
        public AdvertProfile()
        {
            this.CreateMap<AdvertCreate, CreateAdvertDto>().ReverseMap();
        }
    }
}
