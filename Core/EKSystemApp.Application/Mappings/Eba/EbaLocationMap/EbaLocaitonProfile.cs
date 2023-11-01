using AutoMapper;
using EKSystemApp.Application.DTO.Eba.EbaLocation;
using EKSystemApp.Domain.Entities.Admin.Eba;

namespace EKSystemApp.Application.Mappings.Eba.EbaLocationMap
{
    public class EbaLocaitonProfile:Profile
    {
        EbaLocaitonProfile() 
        {
            this.CreateMap<Locaiton, EbaLocationDto>().ReverseMap();
        }
    }
}
