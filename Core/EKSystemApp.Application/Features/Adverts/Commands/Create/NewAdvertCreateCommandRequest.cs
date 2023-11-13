using EKSystemApp.Application.DTO.Advert.Create;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using MediatR;

namespace EKSystemApp.Application.Features.Adverts.Commands.Create
{
    public class NewAdvertCreateCommandRequest:IRequest<CreateAdvertDto>
    {
        public string WorkDefination { get; set; }
        public string PublicQuality { get; set; }
        public string Brand { get; set; }
        public string PositionName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Logo { get; set; } = null;
        public int PeriotNumberId { get; set; }
        public int AdwertNumberId { get; set; }
        public string? TaskTypeName { get; set; }
        public string? CompanyName { get; set; }
        public string OrganizationName { get; set; }
        public string GroupName { get; set; }
        public string DepartmentName { get; set; }
        public string UnitName { get; set; }
        public string WorkTypeName { get; set; }
        public string PositionTypeName { get; set; }
        public string WorkModelName { get; set; }
        public string LocationName { get; set; }
        public string EducationLevelName { get; set; }
        public string? ExperiencePeriodName { get; set; }
        public string MillitaryStatusName { get; set; }
        public string? JobCategoryName { get; set; }
        public string? AdStatusName { get; set; }
        public string? AdPublisherName { get; set; }
        public List<object> SkillAndExpertises { get; set; }
        public List<object> ForeignLanguages { get; set; }
        public List<object> AdQuestions { get; set; }
        public string? OpenClosed { get; set; }
        public string? WorkCategory { get; set; }
    }
}
