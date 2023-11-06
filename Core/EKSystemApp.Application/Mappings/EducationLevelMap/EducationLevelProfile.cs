using AutoMapper;
using EKSystemApp.Application.DTO.Company.List;
using EKSystemApp.Application.DTO.EducationLevel;
using EKSystemApp.Domain.Entities;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Mappings.EducationLevelMap
{
    public class EducationLevelProfile:Profile
    {
        public EducationLevelProfile()
        {
            this.CreateMap<EducationLevel, EducationLevelDto>().ReverseMap();
        }
    }
}
