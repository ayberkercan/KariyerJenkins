using EKSystemApp.Application.Features.AdQuestions.Command.Remove;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using MediatR;

namespace EKSystemApp.Application.Features.AdQuestions.Handler.Remove
{
    public class RemoveAdvertQuestionDefinationCommandHandler : IRequestHandler<RemoveAdvertQuestionDefinationRequest>
    {
        private readonly IGenericRepository<AdvertAdQuestions> advertRepository;
        private readonly IGenericRepository<AdvertAdQuestionAnswerContent> questionContentRepository;

        public RemoveAdvertQuestionDefinationCommandHandler(IGenericRepository<AdvertAdQuestions> advertRepository, IGenericRepository<AdvertAdQuestionAnswerContent> questionContentRepository)
        {
            this.advertRepository = advertRepository;
            this.questionContentRepository = questionContentRepository;
        }

        public async Task<Unit> Handle(RemoveAdvertQuestionDefinationRequest request, CancellationToken cancellationToken)
        {
            var deletedContent = await this.questionContentRepository.GetByIdAsync(request.Id);
         
            var deletedAdvert = await this.advertRepository.GetByIdAsync(deletedContent.AdvertAdQuestionsId.Value);

            if (deletedContent != null)
            {
                await this.questionContentRepository.Remove(deletedContent);
            }
            if (deletedAdvert != null)
            {
                await this.advertRepository.Remove(deletedAdvert);
            }
            return Unit.Value;
        }
    }
}
