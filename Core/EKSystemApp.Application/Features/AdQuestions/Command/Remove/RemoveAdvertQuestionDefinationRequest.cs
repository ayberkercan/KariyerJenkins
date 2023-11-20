using MediatR;

namespace EKSystemApp.Application.Features.AdQuestions.Command.Remove
{
    public class RemoveAdvertQuestionDefinationRequest : IRequest
    {
        public Guid Id { get; set; }
        public RemoveAdvertQuestionDefinationRequest(Guid id)
        {
            Id = id;
        }
    }
}