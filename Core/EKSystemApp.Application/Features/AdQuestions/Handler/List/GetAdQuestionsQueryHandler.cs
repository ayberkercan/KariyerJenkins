using AutoMapper;
using EKSystemApp.Application.DTO.AdQuestion;
using EKSystemApp.Application.DTO.AdvertQuestionsDefinations.List;
using EKSystemApp.Application.Features.AdQuestions.Questions;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Application.Interfaces.Adwerts;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using MediatR;

namespace EKSystemApp.Application.Features.AdQuestions.Handler.List
{
    public class GetAdQuestionsQueryHandler : IRequestHandler<GetAdQuestionsQueryRequest, ICollection<GetAdvertQuestionListDto>>
    {
        private readonly IMapper mapper;
        private IAdvertQuestionsAndContent genericRepository;
        public GetAdQuestionsQueryHandler(IMapper mapper, IAdvertQuestionsAndContent genericRepository)
        {
            this.mapper = mapper;
            this.genericRepository = genericRepository;
        }
        public async Task<ICollection<GetAdvertQuestionListDto>> Handle(GetAdQuestionsQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await genericRepository.GetAdwertQuestionAndContent();
            return mapper.Map<ICollection<GetAdvertQuestionListDto>>(data);
        }
    }
}
