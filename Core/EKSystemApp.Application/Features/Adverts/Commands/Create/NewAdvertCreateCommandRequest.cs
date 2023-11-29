using EKSystemApp.Application.DTO.Advert.Create;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace EKSystemApp.Application.Features.Adverts.Commands.Create
{
    public class NewAdvertCreateCommandRequest : IRequest<CreateAdvertDto>
    {
        public string? WorkDefination { get; set; }
        public string Brands { get; set; }
        public string? PublicQuality { get; set; }
        public string Positions { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public IFormFile? Logo { get; set; }
        public int? PeriotNumberId { get; set; }
        public int? AdvertNumberId { get; set; }
        public string Organizations { get; set; }
        public string Groups { get; set; }
        public string Departments { get; set; }
        public string Units { get; set; }
        public string WorkTypes { get; set; }
        public string PositionTypes { get; set; }
        public string WorkModels { get; set; }
        public string Locations { get; set; }
        public string EducationLevels { get; set; }
        public string MillitaryStatuses { get; set; }
        public string AdvertStatuses { get; set; }
        public string? AdvertPublisherName { get; set; }
        public List<AdvertSkillAndExpertises> AdvertSkillAndExpertises { get; set; }
        public List<AdvertForeignLanguages> AdvertForeignLanguages { get; set; }
        public List<AdvertAdQuestions>? AdvertAdQuestions { get; set; }
        public string? WorkCategories { get; set; }
        public string ExperiencePeriods { get; set; }
        public string? EbaProcessId { get; set; }
        public string? ProcessNumber { get; set; }
    }
}
