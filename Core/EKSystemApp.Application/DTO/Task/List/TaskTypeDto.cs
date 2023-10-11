using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;

namespace EKSystemApp.Application.DTO.Task.List
{
    public class TaskTypeDto
    {
        public string TaskName { get; set; }
        public Guid AdvertCreateId { get; set; }
        public AdvertCreate AdvertCreate { get; set; }
    }
}
