using AutoMapper;
using EKSystemApp.Application.DTO.Eba.EBACompany;
using EKSystemApp.Application.DTO.Eba.EbaDepartment;
using EKSystemApp.Domain.Entities.Admin.Eba;

namespace EKSystemApp.Application.Mappings.Eba.EbaDepartmentMap
{
    public class EbaDepartmentProfile:Profile
    {
        public EbaDepartmentProfile()
        {
            CreateMap<EbaDepartment, EbaDepartmentDto>().ReverseMap();
        }
    }
}
