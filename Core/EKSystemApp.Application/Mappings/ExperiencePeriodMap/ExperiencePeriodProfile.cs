using AutoMapper;
using EKSystemApp.Application.DTO.Company.List;
using EKSystemApp.Application.DTO.ExperiencePeriod;
using EKSystemApp.Domain.Entities;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Mappings.ExperiencePeriodMap
{
    public class ExperiencePeriodProfile:Profile
    {
        public ExperiencePeriodProfile() 
        {
            this.CreateMap<ExperiencePeriod, ExperiencePeriodDto>().ReverseMap(); 
        }
    }
}
