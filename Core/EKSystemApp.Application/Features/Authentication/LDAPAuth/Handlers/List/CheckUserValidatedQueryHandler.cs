using AutoMapper;
using EKSystemApp.Application.DTO.Authorization.LDAPAuth;
using EKSystemApp.Application.DTO.Authorization.User;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.Features.Authentication.LDAPAuth.Queries;
using EKSystemApp.Application.Features.Authentication.Queries;
using EKSystemApp.Application.Features.EBA.TMP.Queries;
using EKSystemApp.Application.Interfaces.ILDAPAuthService;
using EKSystemApp.Application.Interfaces.IUser;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.Authentication.LDAPAuth.Handlers.List
{
    public class CheckUserValidatedQueryHandler : IRequestHandler<CheckUserValidatedQueryRequest, AuthApiResponseDto>
    {
        private readonly ILDAPAuthService ldapAuthService;

        public CheckUserValidatedQueryHandler(ILDAPAuthService ldapAuthService) 
        {
            this.ldapAuthService = ldapAuthService;
        }

        public async Task<AuthApiResponseDto> Handle(CheckUserValidatedQueryRequest request, CancellationToken cancellationToken)
        {
            var response = ldapAuthService.ValidateUser(request).Result;
            return response;
        }
    }
}
