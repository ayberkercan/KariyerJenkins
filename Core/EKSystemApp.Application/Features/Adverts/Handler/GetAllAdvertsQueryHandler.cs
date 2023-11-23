using AutoMapper;
using EKSystemApp.Application.DTO.Advert.List;
using EKSystemApp.Application.Features.Adverts.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Application.Interfaces.IUser;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;
using MediatR;

namespace EKSystemApp.Application.Features.Adverts.Handler
{
    public class GetAllAdvertsQueryHandler : IRequestHandler<GetAllAdvertsQueryRequest, ICollection<AdvertListDto>>
    {
        private readonly IGenericRepository<AdvertCreate> advertRepository;
        private readonly IEbaRepository ebaRepository;
        private readonly IMapper mapper;

        public GetAllAdvertsQueryHandler(IGenericRepository<AdvertCreate> advertRepository, IEbaRepository ebaRepository, IMapper mapper)
        {
            this.advertRepository = advertRepository;
            this.ebaRepository = ebaRepository;
            this.mapper = mapper;
        }

        public async Task<ICollection<AdvertListDto>> Handle(GetAllAdvertsQueryRequest request, CancellationToken cancellationToken)
        {
            var portalAdverts = (await advertRepository.GetAllAsync()).ToList(); //portalda kayıtlı ilanlar

            var ebaForms = await ebaRepository.GetEbaEmployeeRequestForms(); //eBA'da oluşturulan formlar

            var intersectedAdverts = portalAdverts  //processId bilgisi eşleşen veriler bir liste değişkenine eklenir.
                .Where(advert => ebaForms.Any(ebaForm => ebaForm.EbaProcessId == advert.EbaProcessId))
                .ToList();

            return mapper.Map<ICollection<AdvertListDto>>(portalAdverts);
        }

    }
}
