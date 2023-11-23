using AutoMapper;
using EKSystemApp.Application.DTO.Advert.List;
using EKSystemApp.Application.Features.Adverts.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;
using MediatR;

namespace EKSystemApp.Application.Features.Adverts.Handler
{
    public class GetAllFilteredAdvertsQueryHandler : IRequestHandler<GetAllFilteredAdvertsQueryRequest, AdvertListDto>
    {
        private readonly IGenericRepository<AdvertCreate> advertRepository;
        private readonly IMapper mapper;

        public GetAllFilteredAdvertsQueryHandler(IGenericRepository<AdvertCreate> advertRepository, IMapper mapper)
        {
            this.advertRepository = advertRepository;
            this.mapper = mapper;
        }

        public async Task<AdvertListDto> Handle(GetAllFilteredAdvertsQueryRequest request, CancellationToken cancellationToken)
        {
            var data = (await this.advertRepository.GetByFilterAsync(x=>
                                                                        x.PositionName == request.PositionName ||
                                                                        x.StartDate == request.StartDate || 
                                                                        x.EndDate == request.EndDate || 
                                                                        x.PositionTypeName == request.PositionTypeName ||
                                                                        x.AdvertPublisherName == request.AdvertPublisherName || 
                                                                        x.WorkTypeName == request.WorkTypeName ||
                                                                        x.EducationLevelName == request.EducationLevelName || 
                                                                        x.AdvertNumberId == request.AdvertNumberId
            ));

            //if (request != null)
            //{
            //    var dto = request;

            //    data = FilterByDateRange(data, dto.StartDate, dto.EndDate);
            //    data = FilterByString(data, dto.PositionName!, x => x.PositionName);
            //    data = FilterByString(data, dto.PositionTypeName!, x => x.PositionTypeName);
            //    data = FilterByString(data, dto.AdvertPublisherName!, x => x.AdvertPublisherName!);
            //    data = FilterByString(data, dto.WorkTypeName!, x => x.WorkTypeName);
            //    data = FilterByString(data, dto.EducationLevelName!, x => x.EducationLevelName);

            //    if (dto.AdvertNumberId != null && dto.AdvertNumberId != 0)
            //    {
            //        data = data.Where(x => x.AdvertNumberId == dto.AdvertNumberId).ToList();
            //    }
            //}

            return this.mapper.Map<AdvertListDto>(data);
        }

        //private List<AdvertCreate> FilterByDateRange(List<AdvertCreate> data, DateTime? startDate, DateTime? endDate)
        //{var filteredData = data;
            
        //    if (startDate != null && startDate != DateTime.MinValue && endDate != null && endDate != DateTime.MinValue)
        //    {
        //        startDate = startDate.Value.Date;
        //        endDate = endDate.Value.Date.AddDays(1).AddTicks(-1);

        //        filteredData = data
        //            .Where(result => result.StartDate <= endDate && result.EndDate.Date >= startDate)
        //            .ToList();
        //    }

        //    return filteredData;
        //}

        //private  List<AdvertCreate> FilterByString(List<AdvertCreate> data, string value, Func<AdvertCreate, string> selector)
        //{
        //    var filteredData = data;

        //    if (!String.IsNullOrEmpty(value))
        //    {
        //        filteredData = data.Where(x => selector(x).ToUpper().Contains(value.ToUpper())).ToList();
        //    }

        //    return filteredData;
        //}
    }
}
