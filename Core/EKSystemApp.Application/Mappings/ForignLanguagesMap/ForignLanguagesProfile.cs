using AutoMapper;
using EKSystemApp.Application.DTO.ForignLanguages;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;

namespace EKSystemApp.Application.Mappings.ForignLanguagesMap
{
    public class ForignLanguagesProfile:Profile
    {
        public ForignLanguagesProfile()
        {
            this.CreateMap<AdvertForeignLanguages, ForignLanguageDto>().ReverseMap();
        }
    }
}
