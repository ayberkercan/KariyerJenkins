using AutoMapper;
using EKSystemApp.Application.DTO.AdPublisher;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;

namespace EKSystemApp.Application.Mappings.AdPublisherMap
{
    public class AdPublisherProfile:Profile
    {
        public AdPublisherProfile()
        {
            this.CreateMap<AdPublisher, AdPublishersDto>().ReverseMap();
        }
    }
}
