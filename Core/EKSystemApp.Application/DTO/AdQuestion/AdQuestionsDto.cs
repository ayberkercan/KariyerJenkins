using EKSystemApp.Domain.Common;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;

namespace EKSystemApp.Application.DTO.AdQuestion
{
    public class AdQuestionsDto:BaseEntity
    {
        public string AdQuestionName { get; set; }
        public List<AdvertAdQuestionAnswerContent>? AnswerContent { get; set; }
        public Guid? AdvertCreateId { get; set; }
    }
}
