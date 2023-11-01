using AutoMapper;
using EKSystemApp.Application.DTO.MillitaryStatus;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;

namespace EKSystemApp.Application.Mappings.MillitaryStatusesMap
{
    public class MillitaryStatusesProfile:Profile
    {
        public MillitaryStatusesProfile()
        {
            CreateMap<MillitaryStatus, MillitaryStatusDto>().ReverseMap();
        }
    }
}
