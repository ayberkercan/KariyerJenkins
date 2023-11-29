using EKSystemApp.Domain.Common;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;

namespace EKSystemApp.Domain.Entities.Admin.AdminBaseEntity
{
    public class AdvertAdQuestions : BaseEntity
    {
        public string? AdQuestionKey { get; set; }
        public string? AdQuestionName { get; set; }
        public string? AnswerType { get; set; }
        public List<AdvertAdQuestionAnswerContent>? AnswerContent { get; set; }
        public string? AnswerContentDefination { get; set; }
        public Guid? AdvertCreateId { get; set; }
        public AdvertCreate? AdvertCreate { get; set; }
    }
}
