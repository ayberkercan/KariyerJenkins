using AutoMapper;
using EKSystemApp.Application.DTO.Advert.List;
using EKSystemApp.Application.Features.Adverts.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Application.Interfaces.IUser;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;
using MediatR;

namespace EKSystemApp.Application.Features.Adverts.Handler
{
    public class GetAllFilteredAdvertsQueryHandler : IRequestHandler<GetAllFilteredAdvertsQueryRequest, ICollection<AdvertListDto>>
    {
        private readonly IGenericRepository<AdvertCreate> advertRepository;
        private readonly IEbaRepository ebaRepository;
        private readonly IMapper mapper;

        public GetAllFilteredAdvertsQueryHandler(
            IGenericRepository<AdvertCreate> advertRepository,
            IEbaRepository ebaRepository,
            IMapper mapper
            )
        {
            this.advertRepository = advertRepository;
            this.ebaRepository = ebaRepository;
            this.mapper = mapper;
        }

        public async Task<ICollection<AdvertListDto>> Handle(GetAllFilteredAdvertsQueryRequest request, CancellationToken cancellationToken)
        {
            var portalAdverts = await advertRepository.GetAllAdverts(); //portalda kayıtlı ilanlar
            var filterDto = request; //filtre içeriği tanımlanır.

            var ebaForms = await ebaRepository.GetEbaEmployeeRequestForms(portalAdverts); //eBA'da oluşturulan formlar
            var intersectedAdverts = portalAdverts //processId bilgisi eşleşen veriler bir liste değişkenine eklenir.
            .Where(advert => ebaForms.Any(ebaForm => ebaForm.EbaProcessId == advert.EbaProcessId))
            .ToList();

            if (filterDto.AdvertNumberId == null) //eBA'dan uygun kayıtlar döndükten sonra eBA'da olmayan, portaldaki bilgiler için ikinci kez filtrelenir
            {
                intersectedAdverts = FilterByDateRange(intersectedAdverts, filterDto.StartDate, filterDto.EndDate);
                intersectedAdverts = FilterByString(intersectedAdverts, filterDto.PositionTypeName, x => x.PositionKey.ToString());
                intersectedAdverts = FilterByString(intersectedAdverts, filterDto.AdvertPublisherName, x => x.AdvertPublisherName);
                intersectedAdverts = FilterByString(intersectedAdverts, filterDto.AdvertNumberId.ToString(), x => x.AdvertNumberId.ToString());
                intersectedAdverts = FilterByString(intersectedAdverts, filterDto.PositionName.ToString(), x => x.PositionValue.ToString());
            }
            else
            {
                intersectedAdverts = FilterByString(intersectedAdverts, filterDto.AdvertNumberId.ToString(), x => x.AdvertNumberId.ToString());
            }

            return this.mapper.Map<ICollection<AdvertListDto>>(intersectedAdverts); //tipi dönüştürülüp sonuç döner.
        }

        private static List<AdvertListDto> FilterByDateRange(List<AdvertListDto> data, DateTime? startDate, DateTime? endDate)
        {
            var filteredData = data;

            if (startDate != null && startDate != DateTime.MinValue && endDate != null && endDate != DateTime.MinValue)
            {
                startDate = startDate.Value.Date;
                endDate = endDate.Value.Date.AddDays(1).AddTicks(-1);

                filteredData = data
                    .Where(result => result.StartDate <= endDate && result.EndDate >= startDate)
                    .ToList();
            }

            return filteredData;
        }

        private static List<AdvertListDto> FilterByString(List<AdvertListDto> data, string value, Func<AdvertListDto, string> selector)
        {
            var filteredData = data;

            if (!String.IsNullOrEmpty(value))
            {
                filteredData = data.Where(x => selector(x).ToUpper().Contains(value.ToUpper())).ToList();
            }

            return filteredData;
        }
    }
}
