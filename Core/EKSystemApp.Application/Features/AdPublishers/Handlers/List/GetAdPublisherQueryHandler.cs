using AutoMapper;
using EKSystemApp.Application.DTO.AdPublisher;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using MediatR;

namespace EKSystemApp.Application.Features.AdPublishers.Handlers.List
{
    public class GetAdPublisherQueryHandler : IRequestHandler<GetAdPublisherQueryRequest, ICollection<AdPublishersDto>>
    {
        private readonly IMapper mapper;
        private IGenericRepository<AdPublisher> genericRepository;

        public GetAdPublisherQueryHandler(IMapper mapper, IGenericRepository<AdPublisher> genericRepository)
        {
            this.mapper = mapper;
            this.genericRepository = genericRepository;
        }

        public async Task<ICollection<AdPublishersDto>> Handle(GetAdPublisherQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await genericRepository.GetAllAsync();
            return mapper.Map<ICollection<AdPublishersDto>>(data);
        }
    }
}
