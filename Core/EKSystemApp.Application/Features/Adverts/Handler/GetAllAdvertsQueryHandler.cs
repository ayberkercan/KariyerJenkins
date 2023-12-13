using AutoMapper;
using EKSystemApp.Application.DTO.Advert.List;
using EKSystemApp.Application.Features.Adverts.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Application.Interfaces.IElasticSearchService;
using EKSystemApp.Application.Interfaces.IUser;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;
using EKSystemApp.Domain.Entities.eBA;
using MediatR;

namespace EKSystemApp.Application.Features.Adverts.Handler
{
    public class GetAllAdvertsQueryHandler : IRequestHandler<GetAllAdvertsQueryRequest, ICollection<AdvertListDto>>
    {
        private readonly IGenericRepository<AdvertCreate> advertRepository;
        private readonly IEbaRepository ebaRepository;
        private readonly IMapper mapper;
        private readonly IEbaGenericRepository<Titles> positionRepository;
        private readonly IElasticSearchService<AdvertListDto> elasticSearchService;


        public GetAllAdvertsQueryHandler(
            IGenericRepository<AdvertCreate> advertRepository,
            IEbaRepository ebaRepository,
            IMapper mapper,
            IElasticSearchService<AdvertListDto> elasticSearchService,
            IEbaGenericRepository<Titles> positionRepository
            )
        {

            this.advertRepository = advertRepository;
            this.positionRepository = positionRepository;
            this.ebaRepository = ebaRepository;
            this.mapper = mapper;

            this.elasticSearchService = elasticSearchService;
        }

        public async Task<ICollection<AdvertListDto>> Handle(GetAllAdvertsQueryRequest request, CancellationToken cancellationToken)
        {
            var portalAdverts = await advertRepository.GetAllAdverts(); //portalda kayıtlı ilanlar

            var ebaForms = await ebaRepository.GetEbaEmployeeRequestForms(portalAdverts); //eBA'da oluşturulan formlar
          
            var intersectedAdverts = portalAdverts  //processId bilgisi eşleşen veriler bir liste değişkenine eklenir.
                .Where(advert => ebaForms.Any(ebaForm => ebaForm.EbaProcessId == advert.EbaProcessId))
                .ToList();
            //await this.elasticSearchService.InsertBulkDocuments("advertListdto", intersectedAdverts);

            return mapper.Map<ICollection<AdvertListDto>>(intersectedAdverts);
        }

    }
}
