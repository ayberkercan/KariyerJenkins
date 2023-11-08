using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.Features.EBA.TMP.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.eBA;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Handlers.List
{
    public class GetEbaEducationStatusQueryHandler : IRequestHandler<GetEbaEducationStatusQueryRequest, ICollection<EbaKvpDto>>
    {
        private readonly IEbaGenericRepository<EducationStatus> _genericRepository;
        private readonly IMapper mapper;

        public GetEbaEducationStatusQueryHandler(IEbaGenericRepository<EducationStatus> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            this.mapper = mapper;
        }

        public async Task<ICollection<EbaKvpDto>> Handle(GetEbaEducationStatusQueryRequest request, CancellationToken cancellationToken)
        {
            var data = (await _genericRepository.GetAllAsync())
                        .Select(item =>
                        {
                            item.TANIM = item.TANIM.Split('-')[1];
                            return item;
                        })
                        .ToList();

            var result = this.mapper.Map<List<EbaKvpDto>>(data).OrderBy(x => x.Key).ToList();
            return this.mapper.Map<ICollection<EbaKvpDto>>(result);
        }
    }
}
