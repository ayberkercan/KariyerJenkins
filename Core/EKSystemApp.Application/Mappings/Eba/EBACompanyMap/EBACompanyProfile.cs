using AutoMapper;
using EKSystemApp.Application.DTO.Eba.EBACompany;
using EKSystemApp.Domain.Entities.Admin.Eba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Mappings.Eba.EBACompanyMap
{
    public class EBACompanyProfile : Profile
    {
        public EBACompanyProfile()
        {
            CreateMap<EbaCompany, EbaCompanyDto>().ReverseMap();
        }
    }
}
