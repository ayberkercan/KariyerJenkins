﻿using AutoMapper;
using EKSystemApp.Application.DTO.Authorization.User;
using EKSystemApp.Application.Features.Authentication.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Application.Interfaces.IUser;
using EKSystemApp.Domain.Entities;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Handlers
{
    public class GetUsersQueryHandler : IRequestHandler<GetUsersQueryRequest, ICollection<UsersDetailsDto>>
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public GetUsersQueryHandler(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        public async Task<ICollection<UsersDetailsDto>> Handle(GetUsersQueryRequest request, CancellationToken cancellationToken)
        {
            var userData = await this.userRepository.GetUserRoleList();
            return this.mapper.Map<ICollection<UsersDetailsDto>>(userData);
        }
    }
}