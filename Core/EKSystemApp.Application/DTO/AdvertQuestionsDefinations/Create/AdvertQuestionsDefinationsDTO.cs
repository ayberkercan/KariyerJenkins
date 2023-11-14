namespace EKSystemApp.Application.DTO.AdvertQuestionsDefinations.Create
{
    public class AdvertQuestionsDefinationsDTO
    {
        public string QuestionContent { get; set; }
        public string AnswerType { get; set; }
        public string? AnswerContent { get; set; }
        public ICollection<string>? AnswerContentDrop { get; set; }
    }
}
