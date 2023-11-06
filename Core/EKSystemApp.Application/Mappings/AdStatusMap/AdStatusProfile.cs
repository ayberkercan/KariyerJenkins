using AutoMapper;
using EKSystemApp.Application.DTO.AdStatus;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;

namespace EKSystemApp.Application.Mappings.AdStatusMap
{
    public class AdStatusProfile:Profile
    {
        public AdStatusProfile()
        {
            this.CreateMap<AdStatus, AdStatusDto>().ReverseMap();
        }
    }
}
