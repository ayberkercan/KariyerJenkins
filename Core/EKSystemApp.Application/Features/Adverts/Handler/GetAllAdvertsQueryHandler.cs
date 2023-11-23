using AutoMapper;
using EKSystemApp.Application.DTO.Advert.List;
using EKSystemApp.Application.Features.Adverts.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Application.Interfaces.IElasticSearchService;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;
using MediatR;

namespace EKSystemApp.Application.Features.Adverts.Handler
{
    public class GetAllAdvertsQueryHandler : IRequestHandler<GetAllAdvertsQueryRequest, ICollection<AdvertListDto>>
    {
        private readonly IGenericRepository<AdvertCreate> advertRepository;
        private readonly IElasticSearchService<AdvertCreate> elasticSearch;
        private readonly IMapper mapper;

        public GetAllAdvertsQueryHandler(IGenericRepository<AdvertCreate> advertRepository, IMapper mapper, IElasticSearchService<AdvertCreate> elasticSearch)
        {
            this.advertRepository = advertRepository;
            this.mapper = mapper;
            this.elasticSearch = elasticSearch;
        }

        public async Task<ICollection<AdvertListDto>> Handle(GetAllAdvertsQueryRequest request, CancellationToken cancellationToken)
        {
            await this.elasticSearch.ChekIndex("AdvertList");
            var data = (await this.advertRepository.GetAllAsync()).ToList();
            await this.elasticSearch.InsertBulkDocuments("AdvertList",data);
            return this.mapper.Map<ICollection<AdvertListDto>>(data);
        }
    }
}
