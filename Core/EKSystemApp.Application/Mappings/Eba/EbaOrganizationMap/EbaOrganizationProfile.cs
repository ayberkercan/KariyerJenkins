using AutoMapper;
using EKSystemApp.Application.DTO.Eba.EbaOrganization;
using EKSystemApp.Domain.Entities.Admin.Eba;

namespace EKSystemApp.Application.Mappings.Eba.EbaOrganizationMap
{
    public class EbaOrganizationProfile:Profile
    {
        public EbaOrganizationProfile()
        {
            this.CreateMap<Organization, EbaOrganizationDto>().ReverseMap();
        }
    }
}
