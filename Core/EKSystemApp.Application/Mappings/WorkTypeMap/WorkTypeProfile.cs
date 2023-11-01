using AutoMapper;
using EKSystemApp.Application.DTO.WorkModel;
using EKSystemApp.Application.DTO.WorkType;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Mappings.WorkTypeMap
{
    public class WorkTypeProfile:Profile
    {
        public WorkTypeProfile() 
        {
            CreateMap<WorkType, WorkTypeDto>().ReverseMap();
        }
    }
}
