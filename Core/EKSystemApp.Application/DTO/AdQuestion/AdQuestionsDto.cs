using EKSystemApp.Domain.Common;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;

namespace EKSystemApp.Application.DTO.AdQuestion
{
    public class AdQuestionsDto:BaseEntity
    {
        public string QuestionContent { get; set; }
        public string AnswerType { get; set; }
        public string? AnswerContent { get; set; }
        public string AdQuestionName { get; set; }
    }
}
