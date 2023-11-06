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
    public class GetEbaShiftStatusQueryHandler : IRequestHandler<GetEbaShiftStatusQueryRequest, ICollection<EbaStrKvpDto>>
    {
        private readonly IEbaGenericRepository<ShiftStatus> _genericRepository;
        private readonly IMapper _mapper;

        public GetEbaShiftStatusQueryHandler(IEbaGenericRepository<ShiftStatus> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task<ICollection<EbaStrKvpDto>> Handle(GetEbaShiftStatusQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _genericRepository.GetAllAsync();

            var result = _mapper.Map<List<EbaStrKvpDto>>(data);

            return result;
        }
    }
}
