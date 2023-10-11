using AutoMapper;
using EKSystemApp.Application.DTO.Authorization.Role;
using EKSystemApp.Application.Features.Authentication.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Handlers.List
{
    public class GetRolesQueryHander : IRequestHandler<GetRolesQueryRequest, ICollection<AppRoleListDto>>
    {
        private readonly IGenericRepository<AppRole> repository;
        private readonly IMapper mapper;
        public GetRolesQueryHander(IGenericRepository<AppRole> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<ICollection<AppRoleListDto>> Handle(GetRolesQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await repository.GetAllAsync();
            return mapper.Map<ICollection<AppRoleListDto>>(data);
        }
    }
}
