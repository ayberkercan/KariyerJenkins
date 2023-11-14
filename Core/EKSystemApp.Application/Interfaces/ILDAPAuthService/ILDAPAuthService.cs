using EKSystemApp.Application.DTO.Authorization.LDAPAuth;
using EKSystemApp.Application.Features.Authentication.LDAPAuth.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Interfaces.ILDAPAuthService
{
    public interface ILDAPAuthService
    {
        Task<AuthApiResponseDto> ValidateUser(CheckUserValidatedQueryRequest request);
    }
}
