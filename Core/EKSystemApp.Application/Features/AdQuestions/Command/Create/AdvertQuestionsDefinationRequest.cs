using EKSystemApp.Application.DTO.AdQuestion;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using MediatR;

namespace EKSystemApp.Application.Features.AdQuestions.Command.Create
{
    public class AdvertQuestionsDefinationRequest : IRequest<AdQuestionsDto>
    {
        public string AdQuestionName { get; set; }
        public string AnswerType { get; set; }
        public List<AdvertAdQuestionAnswerContent>? AnswerContent { get; set; }
        public Guid? AdvertCreateId { get; set; }
        public string? AnswerContentDefination { get; set; }
    }
}
