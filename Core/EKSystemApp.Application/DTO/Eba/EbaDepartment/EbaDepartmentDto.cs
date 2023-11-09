using EKSystemApp.Domain.Common;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;

namespace EKSystemApp.Application.DTO.Eba.EbaDepartment
{
    public class EbaDepartmentDto : BaseEntity
    {
        public string DepartmentName { get; set; }
        public Guid AdvertCreateId { get; set; }
        public AdvertCreate AdvertCreate { get; set; }
    }
}
