using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EKSystemApp.Application.DTO.Company;
using EKSystemApp.Application.DTO.Products;
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
