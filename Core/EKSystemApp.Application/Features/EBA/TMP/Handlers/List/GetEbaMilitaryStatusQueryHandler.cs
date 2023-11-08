using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.Features.EBA.TMP.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.eBA;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Handlers.List
{
    public class GetEbaMilitaryStatusQueryHandler : IRequestHandler<GetEbaMilitaryStatusQueryRequest, ICollection<EbaStrKvpDto>>
    {
        private readonly IEbaGenericRepository<MilitaryStatus> genericRepository;
        private readonly IMapper mapper;

        public GetEbaMilitaryStatusQueryHandler(IEbaGenericRepository<MilitaryStatus> genericRepository, IMapper mapper)
        {
            this.genericRepository = genericRepository;
            this.mapper = mapper;
        }

        public async Task<ICollection<EbaStrKvpDto>> Handle(GetEbaMilitaryStatusQueryRequest request, CancellationToken cancellationToken)
        {
            var data = (await this.genericRepository.GetAllAsync())
                        .OrderByDescending(x=>x.ID)
                        .ToList();
            var result = this.mapper.Map<List<EbaStrKvpDto>>(data);
            return this.mapper.Map<ICollection<EbaStrKvpDto>>(result);
        }
    }
}
