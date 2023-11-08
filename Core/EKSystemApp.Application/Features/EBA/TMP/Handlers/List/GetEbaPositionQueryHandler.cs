using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.Features.EBA.TMP.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.eBA;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Handlers.List
{
    public class GetEbaPositionQueryHandler : IRequestHandler<GetEbaPositionQueryRequest, ICollection<EbaKvpDto>>
    {
        private readonly IEbaGenericRepository<Titles> genericRepository;
        private readonly IMapper mapper;

        public GetEbaPositionQueryHandler(IEbaGenericRepository<Titles> genericRepository, IMapper mapper)
        {
            this.genericRepository = genericRepository;
            this.mapper = mapper;
        }

        public async Task<ICollection<EbaKvpDto>> Handle(GetEbaPositionQueryRequest request, CancellationToken cancellationToken)
        {
            var userData = await this.genericRepository.GetAllAsync();
            var result = this.mapper.Map<List<EbaKvpDto>>(userData).OrderBy(x => x.Value).ToList();
            return this.mapper.Map<ICollection<EbaKvpDto>>(result);
        }
    }
}
