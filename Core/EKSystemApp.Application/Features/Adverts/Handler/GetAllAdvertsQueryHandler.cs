using AutoMapper;
using EKSystemApp.Application.DTO.Advert.List;
using EKSystemApp.Application.Features.Adverts.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;
using MediatR;

namespace EKSystemApp.Application.Features.Adverts.Handler
{
    public class GetAllAdvertsQueryHandler : IRequestHandler<GetAllAdvertsQueryRequest, ICollection<AdvertListDto>>
    {
        private readonly IGenericRepository<AdvertCreate> advertRepository;
        private readonly IMapper mapper;

        public GetAllAdvertsQueryHandler(IGenericRepository<AdvertCreate> advertRepository, IMapper mapper)
        {
            this.advertRepository = advertRepository;
            this.mapper = mapper;
        }

        public async Task<ICollection<AdvertListDto>> Handle(GetAllAdvertsQueryRequest request, CancellationToken cancellationToken)
        {
            var data = (await this.advertRepository.GetAllAsync()).ToList();

            return this.mapper.Map<ICollection<AdvertListDto>>(data);
        }
    }
}
