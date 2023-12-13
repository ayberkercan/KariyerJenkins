using EKSystemApp.Domain.Common;

namespace EKSystemApp.Domain.Entities.Admin.WorkStepManager
{
    public class WorksStepManager : BaseEntity
    {
        public string WorkSteps { get; set; }
        public string WorkStepsTitle { get; set; }
        public string Defination { get; set; }
        public string Image { get; set; }
        public Guid AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
