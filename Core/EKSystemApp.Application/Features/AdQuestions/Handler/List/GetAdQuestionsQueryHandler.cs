using AutoMapper;
using EKSystemApp.Application.DTO.AdQuestion;
using EKSystemApp.Application.Features.AdQuestions.Questions;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using MediatR;

namespace EKSystemApp.Application.Features.AdQuestions.Handler.List
{
    public class GetAdQuestionsQueryHandler : IRequestHandler<GetAdQuestionsQueryRequest, ICollection<AdQuestionsDto>>
    {
        private readonly IMapper mapper;
        private IGenericRepository<AdvertAdQuestions> genericRepository;
        public GetAdQuestionsQueryHandler(IMapper mapper, IGenericRepository<AdvertAdQuestions> genericRepository)
        {
            this.mapper = mapper;
            this.genericRepository = genericRepository;
        }
        public async Task<ICollection<AdQuestionsDto>> Handle(GetAdQuestionsQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await genericRepository.GetAllAsync();
            return mapper.Map<ICollection<AdQuestionsDto>>(data);
        }
    }
}
