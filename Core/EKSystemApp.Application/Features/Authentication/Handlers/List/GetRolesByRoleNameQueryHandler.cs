using System.Diagnostics.Contracts;
using AutoMapper;
using EKSystemApp.Application.DTO.Authorization.Role;
using EKSystemApp.Application.Features.Authentication.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities;
using MediatR;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EKSystemApp.Application.Features.Authentication.Handlers.List
{
    public class GetRolesByRoleNameQueryHandler : IRequestHandler<GetRolesByRoleNameQueryRequest, ICollection<AppRoleListDto>>
    {
        private readonly IGenericRepository<AppRole> repository;
        private readonly IMapper mapper;
        public GetRolesByRoleNameQueryHandler(IGenericRepository<AppRole> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<ICollection<AppRoleListDto>> Handle(GetRolesByRoleNameQueryRequest request, CancellationToken cancellationToken)
        {
            var dto = await this.repository.GetAllAsync();
            foreach (var item in dto)
            {
                if (request.roleName == "Administrators")
                {
                    var k = dto.Where(p => p.Name == request.roleName || p.Name == "HumanResources");

                    return mapper.Map<ICollection<AppRoleListDto>>(k);
                }
                if (request.roleName == "HumanResources")
                {
                    var k = dto.Where(p => p.Name == request.roleName);
                    return mapper.Map<ICollection<AppRoleListDto>>(k);
                }
            }
            return mapper.Map<ICollection<AppRoleListDto>>(dto);

        }
    }
}
