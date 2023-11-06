using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EKSystemApp.Application.DTO.Authorization.User;
using EKSystemApp.Application.Features.Authentication.Queries;
using EKSystemApp.Application.Interfaces.IUser;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Handlers.List
{
    public class GetAllUsersInTableViewQueryHandler : IRequestHandler<GetAllUsersInTableViewQueryRequest, ICollection<UsersDetailsDto>>
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;
        public GetAllUsersInTableViewQueryHandler(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }
        public async Task<ICollection<UsersDetailsDto>> Handle(GetAllUsersInTableViewQueryRequest request, CancellationToken cancellationToken)
        {
            var userAllTable = await this.userRepository.GetUserRoleAndMenuListById(request.role);
            return mapper.Map<ICollection<UsersDetailsDto>>(userAllTable);
        }
    }
}
