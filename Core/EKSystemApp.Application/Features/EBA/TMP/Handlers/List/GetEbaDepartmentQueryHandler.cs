using AutoMapper;
using EKSystemApp.Application.DTO.Authorization.User;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.Features.Authentication.Queries;
using EKSystemApp.Application.Features.EBA.TMP.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Application.Interfaces.IUser;
using EKSystemApp.Domain.Entities.eBA;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Handlers.List
{
    public class GetEbaDepartmentQueryHandler : IRequestHandler<GetEbaDepartmentQueryRequest, ICollection<EbaKvpDto>>
    {
        private readonly IEbaRepository _ebaRepository;
        private readonly IMapper _mapper;

        public GetEbaDepartmentQueryHandler(IEbaRepository ebaRepository, IMapper mapper)
        {
            _ebaRepository = ebaRepository;
            _mapper = mapper;
        }

        public async Task<ICollection<EbaKvpDto>> Handle(GetEbaDepartmentQueryRequest request, CancellationToken cancellationToken)
        {
            var userData = await _ebaRepository.GetEbaItemsByUpObjId<EbaKvpDto>(request.Request.upKey);

            return userData;
        }
    }
}
