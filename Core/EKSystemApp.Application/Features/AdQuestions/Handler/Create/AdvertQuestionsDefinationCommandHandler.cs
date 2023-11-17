using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EKSystemApp.Application.DTO.AdQuestion;
using EKSystemApp.Application.DTO.AdvertQuestionsDefinations.Create;
using EKSystemApp.Application.Features.AdQuestions.Command.Create;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using MediatR;

namespace EKSystemApp.Application.Features.AdQuestions.Handler.Create
{
    public class AdvertQuestionsDefinationCommandHandler : IRequestHandler<AdvertQuestionsDefinationRequest, AdQuestionsDto>
    {
        private readonly IGenericRepository<AdvertAdQuestions> repository;
        private readonly IGenericRepository<AdvertAdQuestionAnswerContent> answerRepository;
        private readonly IMapper mapper;

        public AdvertQuestionsDefinationCommandHandler(IGenericRepository<AdvertAdQuestions> repository, IMapper mapper, IGenericRepository<AdvertAdQuestionAnswerContent> answerRepository)
        {
            this.repository = repository;
            this.mapper = mapper;
            this.answerRepository = answerRepository;
        }
        public async Task<AdQuestionsDto> Handle(AdvertQuestionsDefinationRequest request, CancellationToken cancellationToken)
        {
            var questions = new AdvertAdQuestions
            {
                AdQuestionName = request.AdQuestionName,
                AdvertCreateId = request.AdvertCreateId,
            };
            var result = await this.repository.CreateAsync(questions);

            foreach (var item in request.AnswerContent!)
            {
                var content = new AdvertAdQuestionAnswerContent
                {
                    AdvertAdQuestionsId = questions.Id,
                    AnswerContentName = item.AnswerContentName,
                };
                await this.answerRepository.CreateAsync(content);
            }
            return this.mapper.Map<AdQuestionsDto>(result);
        }
    }
}
