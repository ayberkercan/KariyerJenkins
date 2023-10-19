using EKSystemApp.Domain.Common;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;

namespace EKSystemApp.Application.DTO.PositionsTypes.List
{
    public class PositionsTypesDto : BaseEntity
    {
        public string PositionName { get; set; }
        public Guid AdvertCreateId { get; set; }
    }
}
