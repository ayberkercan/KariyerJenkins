using EKSystemApp.Domain.Common;

namespace EKSystemApp.Application.DTO.Eba.EbaPosition
{
    public class EbaPositionDto:BaseEntity
    {
        public int key { get; set; }
        public string value { get; set; }
    }
}
