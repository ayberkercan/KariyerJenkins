using AutoMapper;
using EKSystemApp.Application.DTO.Company.List;
using EKSystemApp.Domain.Entities;

namespace EKSystemApp.Application.Mappings.CompanyMap
{
    public class AppUserCompanyProfile : Profile
    {
        public AppUserCompanyProfile()
        {
            this.CreateMap<Company, CompaniesListDto>().ReverseMap();
        }
    }
}
