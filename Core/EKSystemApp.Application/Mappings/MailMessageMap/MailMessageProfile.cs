using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EKSystemApp.Application.DTO.JobCategory;
using EKSystemApp.Application.DTO.MailMessage;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using EKSystemApp.Domain.Entities.Admin.MailMesaj;

namespace EKSystemApp.Application.Mappings.MailMessageMap
{
    public class MailMessageProfile : Profile
    {
        public MailMessageProfile()
        {
            CreateMap<MailMessageTemplate, MailMessageDto>().ReverseMap();
        }
    }
}
