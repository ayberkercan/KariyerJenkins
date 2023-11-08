using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.Features.EBA.TMP.Queries;
using EKSystemApp.Application.Interfaces.IUser;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Handlers.List
{
    public class GetEbaDepartmentQueryHandler : IRequestHandler<GetEbaDepartmentQueryRequest, ICollection<EbaKvpDto>>
    {
        private readonly IEbaRepository _ebaRepository;
        private readonly IMapper mapper;

        public GetEbaDepartmentQueryHandler(IEbaRepository ebaRepository, IMapper mapper)
        {
            _ebaRepository = ebaRepository;
            this.mapper = mapper;
        }

        public async Task<ICollection<EbaKvpDto>> Handle(GetEbaDepartmentQueryRequest request, CancellationToken cancellationToken)
        {
            var userData = await _ebaRepository.GetEbaItemsByUpObjId<EbaKvpDto>(request.Request.UpKey);
            return this.mapper.Map<ICollection<EbaKvpDto>>(userData);
        }
    }
}
