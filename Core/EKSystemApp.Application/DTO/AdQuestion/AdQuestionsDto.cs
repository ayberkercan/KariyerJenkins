using EKSystemApp.Domain.Common;

namespace EKSystemApp.Application.DTO.AdQuestion
{
    public class AdQuestionsDto:BaseEntity
    {
        public string QuestionContent { get; set; }
        public string AnswerType { get; set; }
        public string? AnswerContent { get; set; }
    }
}
