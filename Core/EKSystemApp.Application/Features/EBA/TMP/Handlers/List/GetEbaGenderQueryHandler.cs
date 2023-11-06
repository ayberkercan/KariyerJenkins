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
    public class GetEbaGenderQueryHandler : IRequestHandler<GetEbaGenderQueryRequest, ICollection<EbaStrKvpDto>>
    {
        private readonly IEbaGenericRepository<Genders> _genericRepository;
        private readonly IMapper _mapper;

        public GetEbaGenderQueryHandler(IEbaGenericRepository<Genders> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task<ICollection<EbaStrKvpDto>> Handle(GetEbaGenderQueryRequest request, CancellationToken cancellationToken)
        {
            var data = (await _genericRepository.GetAllAsync()).OrderBy(x => x.ORDER);

            var result = _mapper.Map<List<EbaStrKvpDto>>(data).ToList();

            return result;
        }
    }
}
