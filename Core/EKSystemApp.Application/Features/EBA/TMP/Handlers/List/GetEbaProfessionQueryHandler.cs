using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.Features.EBA.TMP.Queries;
using EKSystemApp.Application.Interfaces.IUser;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Handlers.List
{
    public class GetEbaProfessionQueryHandler : IRequestHandler<GetEbaProfessionQueryRequest, ICollection<EbaKvpDto>>
    {
        private readonly IEbaRepository ebaRepository;
        private readonly IMapper mapper;

        public GetEbaProfessionQueryHandler(IEbaRepository ebaRepository, IMapper mapper)
        {
            this.ebaRepository = ebaRepository;
            this.mapper = mapper;
        }

        public async Task<ICollection<EbaKvpDto>> Handle(GetEbaProfessionQueryRequest request, CancellationToken cancellationToken)
        {
            var userData = await this.ebaRepository.GetEbaProfessionsByParameters(request.Request);
            return this.mapper.Map<ICollection<EbaKvpDto>>(userData);
        }
    }
}
